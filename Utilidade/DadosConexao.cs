using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestaoFinanceira.Utilidade
{
    public class DadosConexao
    {
        public static string servidor = "localhost";
        public static string banco = "gestaofinanceira";
        public static string usuario = "root";
        public static string senha = "1234";

        public static string stringConexao
        {
            get
            {
                return "Server ="+servidor+";Database ="+banco+"; Uid ="+usuario+"; Pwd ="+senha;
                
            }
        }
    }
}
