using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace GestaoFuncarios.Data
{
    public static class ConexaoBD
    {
        private static readonly string
            STRINGCONEXAO = "Server=localhost;" +
                            "Port=3306;" +
                            "Database=gestao_funcionario;" + 
                            "User ID=root;" + 
                            "Password=;";
        public static MySqlConnection ObterConexao()
        {
            return new MySqlConnection(STRINGCONEXAO);
        }
    }
}
