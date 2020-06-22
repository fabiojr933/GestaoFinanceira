using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Modelo
{
    public class Modelo_Usuario
    {
        public Modelo_Usuario()
        {
            this.id = 0;
            this.usuario = "";
            this.senha = "";
        }

        public int id { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
    }
}
