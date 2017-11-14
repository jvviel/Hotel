using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Camadas.DAL
{
    public class Conexao
    {
        public static String getConexao()
        {
            return @"Data Source=VIEL\sqlexpress;Initial Catalog=HOTEL;Integrated Security=True";
        }
    }
}
