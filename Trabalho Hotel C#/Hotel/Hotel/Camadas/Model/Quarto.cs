using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Camadas.Model
{
    public class Quarto
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public float valor { get; set; }
        public char status { get; set; }
    }
}
