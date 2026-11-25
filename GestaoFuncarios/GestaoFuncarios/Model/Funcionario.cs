using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFuncarios.Model
{
    public abstract class Funcionario
    {
        //argumentos
        public int     Matricula { get; set; }
        public string  Nome { get; set; }
        public decimal SalarioBase { get; set; }

        //metodo construtor
        protected Funcionario(int matricula, string nome, decimal salarioBase)
        {
            this.Matricula = matricula;
            this.Nome = nome;
            this.SalarioBase = salarioBase;
        }

        //métodos
        public abstract decimal CalcularSalario();

        public override string ToString()
        {
            // Matrícula: xXXXX - Nome: XXXXXX
            string x = "Matrícula: " + this.Matricula + " | Nome: " + this.Nome;
            //concatenando variáveis dentro de uma string
            return $"Matrícula: {this.Matricula} | Nome: {this.Nome}";
        }
        

    }
}
