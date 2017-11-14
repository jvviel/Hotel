using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hotel.Relatorios
{
    public static class Funcoes
    {

        public static string diretorioPasta()
        {
            string folder = @"C:\Users\p-vit\Desktop\BCC\Linguagens de Programação\Trabalho Hotel C#\Relatórios";

            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            return folder;
        }
    }
}
