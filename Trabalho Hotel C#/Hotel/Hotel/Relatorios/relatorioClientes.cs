using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hotel.Relatorios
{
    public static class relatorioClientes
    {
        public static void impRelatorioCliente()
        {
            Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();
            List<Camadas.Model.Cliente> lstCliente = new List<Camadas.Model.Cliente>();

            lstCliente = bllCliente.Select();

            string folder = Funcoes.diretorioPasta();
            string arquivo = folder + @"\RelatorioClientes.html";

            using (StreamWriter sw = new StreamWriter(arquivo))
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine(@"<meta http-equiv='Content-Type' content='text/html; charset=utf-8\'>");
                sw.WriteLine("</head>");
                sw.WriteLine("<body>");
                sw.WriteLine("<center> <h2> Relatório de Clientes do Hotel </h2>");
                sw.WriteLine("<hr width='1300px'>");
                sw.WriteLine("<p align='center'><img src = 'Fundo.jpg'></img></p>");
                sw.WriteLine("<br><br> <table border = 3>");
                sw.WriteLine("<tr bgcolor='05A4FA'>");
                sw.WriteLine("<th align= 'center' width='200px'>Nome </th>");
                sw.WriteLine("<th align= 'center' width='100px'>Endereço </th>");
                sw.WriteLine("<th align='center' width='60px'>Cidade </th>");
                sw.WriteLine("<th align='center' width='30px'>Estado</th>");
                sw.WriteLine("<th align='center' width='30px'>Telefone </th>");
                sw.WriteLine("</tr>");

                int totalClientes = 0;

                foreach (Camadas.Model.Cliente cliente in lstCliente)
                {
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<th align='left' width='30px'>" + cliente.nome + "</th>");
                    sw.WriteLine("<th align= 'left' width='200px'>" + cliente.endereco + "</th>");
                    sw.WriteLine("<th align= 'left' width='100px'>" +cliente.cidade + "</th>");
                    sw.WriteLine("<th align='center' width='60px'>" + cliente.estado + "</th>");
                    sw.WriteLine("<th align='left' width='60px'>" + cliente.fone + "</th>");
                    sw.WriteLine("</tr>");

                    totalClientes++;

                }

                sw.WriteLine("</table>");
                sw.WriteLine("<b><hr align = 'center' border = '5px' width = '1300px'><br>");
                sw.WriteLine("Total de clientes cadastrados no Hotel: " + totalClientes + "<br>");
                sw.WriteLine("</b></center></body>");
                sw.WriteLine("</html>");
            }

            System.Diagnostics.Process.Start(arquivo);
        }
    }
}
