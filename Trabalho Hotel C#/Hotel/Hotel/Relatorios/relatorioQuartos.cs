using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hotel.Relatorios
{
    public static class relatorioQuartos
    {
        public static void impRelatorioQuartos()
        {
            Camadas.BLL.Quarto bllQuarto = new Camadas.BLL.Quarto();
            List<Camadas.Model.Quarto> lstQuarto = new List<Camadas.Model.Quarto>();

            lstQuarto = bllQuarto.Select();

            string folder = Funcoes.diretorioPasta();
            string arquivo = folder + @"\RelatorioQuartos.html";

            using (StreamWriter sw = new StreamWriter(arquivo))
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine(@"<meta http-equiv='Content-Type' content='text/html; charset=utf-8\'>");
                sw.WriteLine("</head>");
                sw.WriteLine("<body>");
                sw.WriteLine("<center> <h2> Relatório de Quartos do Hotel </h2>");
                sw.WriteLine("<hr width='1300px'>");
                sw.WriteLine("<p align='center'><img src = 'Fundo.jpg'></img></p>");
                sw.WriteLine("<br><br> <table border=3>");
                sw.WriteLine("<tr bgcolor = '05A4FA'>");
                sw.WriteLine("<th align='center' width='30px'>Id </th>");
                sw.WriteLine("<th align= 'left' width='200px'>Descrição </th>");
                sw.WriteLine("<th align= 'center' width='100px'>Valor R$ </th>");
                sw.WriteLine("<th align='center' width='60px'>Status </th>");
                sw.WriteLine("</tr>");

                int totalQuartos = 0;
                int totalQuartosDisponiveis = 0;
                int totalQuartosReservados = 0;
                string status = "D";
                

                foreach (Camadas.Model.Quarto quarto in lstQuarto)
                {
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<th align='center' width='30px'>" + quarto.id + "</th>");
                    sw.WriteLine("<th align= 'left' width='200px'>" + quarto.descricao + "</th>");
                    sw.WriteLine("<th align= 'center' width='100px'>" + quarto.valor.ToString("0.00") + "</th>");
                    sw.WriteLine("<th align='center' width='60px'>" + quarto.status + "</th>");
                    sw.WriteLine("</tr>");

                    totalQuartos++;
                    if (quarto.status == Convert.ToChar(status))
                        totalQuartosDisponiveis++;
                    else totalQuartosReservados++;
                    
                }

                sw.WriteLine("</table>");
                sw.WriteLine("<b><hr align = 'center' border = '5px' width = '1300px'><br>");
                sw.WriteLine("Total de quartos registrados: " + totalQuartos + "<br>");
                sw.WriteLine("Total de quartos disponíveis: " + totalQuartosDisponiveis + "<br>");
                sw.WriteLine("Total de quartos reservados: " + totalQuartosReservados + "<br>");
                sw.WriteLine("</b></center></body>");
                sw.WriteLine("</html>");
            }

            System.Diagnostics.Process.Start(arquivo);
        }
    }
}
