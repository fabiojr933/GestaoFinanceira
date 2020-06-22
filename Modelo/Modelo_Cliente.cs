using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Modelo
{
    public class Modelo_Cliente
    {
        public int id { get; set; }
        public string cpf { get; set; }
        public string nome { get; set; }
        public DateTime datacadastro { get; set; }
        public string cep { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string email { get; set; }
        public string fomecelular { get; set; }
        public string observacao { get; set; }
    }   
}
