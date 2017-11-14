using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Camadas.Model
{
    public class ItemReserva
    {
        public int id { get; set; }
        public int reserva { get; set; }
        public int quarto { get; set; }
        public DateTime entrada { get; set; }
        public float valor { get; set; }
        public int dias { get; set; }
    }
}
