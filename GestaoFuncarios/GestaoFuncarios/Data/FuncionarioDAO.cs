using GestaoFuncarios.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFuncarios.Data
{
    public class FuncionarioDAO
    {
        //Este método pega '1' linha do result do banco de dados
        // e faço a conversão para um objeto 'Funcionario'
        private Funcionario CriarFuncionarioApartirResultBD(MySqlDataReader reader)
        {
            int matricula   = reader.GetInt32("matricula");
            string nome     = reader.GetString("nome");
            string tipo     = reader.GetString("tipo");
            decimal salario = reader.GetDecimal("salario_base");

            if(tipo == "CLT")
            {
                Funcionario funcionario = new FuncionarioCLT(matricula, nome, salario);
                return funcionario;
            }
            else
            { //COMISSIONADO
                decimal vendas     = reader.GetDecimal("total_vendas");
                decimal percentual = reader.GetDecimal("percentual_comissao");
                Funcionario funcionario = new
                    FuncionarioComissionado(matricula, nome, salario,
                    vendas, percentual);
                return funcionario;
            }
        }

        private void PreencherParametros(MySqlCommand comando, Funcionario f)
        {
            //se f (funcionario) é um objeto de FuncionarioComissionado
            // pois estamos trabalhando com Herança e Polimorfismo
            bool comissionado = f is FuncionarioComissionado;
            comando.Parameters.AddWithValue("@matricula", f.Matricula);
            comando.Parameters.AddWithValue("@nome", f.Nome);
            comando.Parameters
                .AddWithValue("@tipo", comissionado ? "COMISSIONADO" : "CLT");
            comando.Parameters.AddWithValue("@salario", f.SalarioBase);
            //se o objeto 'f' for um objeto FuncionarioComissionado, então
            // ele converte o 'f' para 'fc' para assim eu ter acesso aos
            // argumentos de TotalVendas e PercentualComissao
            if(f is FuncionarioComissionado fc)
            {
                comando.Parameters.AddWithValue("@vendas", fc.TotalVendas);
                comando.Parameters.AddWithValue("@percentual", fc.PercentualComissao);
            }
            else
            { //CLT
                comando.Parameters.AddWithValue("@vendas", DBNull.Value);
                comando.Parameters.AddWithValue("@percentual", DBNull.Value);
            }

        }

        public void Inserir(Funcionario funcionario)
        {
            using var conexao = ConexaoBD.ObterConexao();
            conexao.Open();
            string sql = @"
                    INSERT INTO funcionarios
                      (matricula, nome, tipo, salario_base,
                       total_vendas, percentual_comissao)
                    VALUES
                      (@matricula,@nome,@tipo,@salario,
                       @vendas,@percentual)";
            using var comando = new MySqlCommand(sql, conexao);
            //preencher os parâmetros
            PreencherParametros(comando, funcionario);
            //executar no banco de dados
            comando.ExecuteNonQuery();
            //ExecuteNonQuery - não tem retorno - INSERT UPDATE DELETE
        }
        
        public void Atualizar(Funcionario funcionario)
        {
            using var conexao = ConexaoBD.ObterConexao();
            conexao.Open();
            string sql = @"
                    UPDATE funcionario SET
                      nome                 = @nome,
                      tipo                 = @tipo, 
                      salario_base         = @salario,
                      total_vendas         = @vendas,
                      @percentual_comissao = @percentual
                   WHERE matricula = @matricula
                ";
            using var comando = new MySqlCommand(sql, conexao);
            PreencherParametros(comando, funcionario);
            comando.ExecuteNonQuery();
        }

        public void Excluir(int matricula)
        {
            using var conexao = ConexaoBD.ObterConexao();
            conexao.Open();
            string sql = "DELETE FROM funcionarios WHERE matricula = @matricula";
            using var comando = new MySqlCommand(sql, conexao);
            //preencher o parâmetro de matrícula
            comando.Parameters.AddWithValue("@matricula", matricula);
            comando.ExecuteNonQuery();
        }

        public Funcionario? Buscar(int matricula)
        {
            using var conexao = ConexaoBD.ObterConexao();
            conexao.Open();
            string sql = "SELECT * FROM funcionarios WHERE matricula = @matricula";
            using var comando = new MySqlCommand(sql, conexao);
            //preencher o parâmetro de matrícula
            comando.Parameters.AddWithValue("@matricula", matricula);
            //neste ponto executa o comando no BD e espera a resposta
            // em tabela (vetor)
            using var reader = comando.ExecuteReader();
            if (!reader.Read()) //se não encontrou ninguem, retorna null
                return null;
            return CriarFuncionarioApartirResultBD(reader);
        }

        public List<Funcionario> Listar()
        {
            var funcionarios = new List<Funcionario>(); //lista zerada aqui!
            using var conexao = ConexaoBD.ObterConexao();
            conexao.Open();
            string sql = "SELECT * FROM funcionarios ORDER BY matricula";
            using var comando = new MySqlCommand(sql, conexao);
            using var reader = comando.ExecuteReader();
            //dar looping no RESULT do BD (linha a linha)
            while (reader.Read())
            {
                Funcionario f = CriarFuncionarioApartirResultBD(reader);
                funcionarios.Add(f);
            }
            return funcionarios;
        }
        
    }
}
