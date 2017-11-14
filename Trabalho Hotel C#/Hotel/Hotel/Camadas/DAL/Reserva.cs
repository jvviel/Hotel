using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Hotel.Camadas.DAL
{
    public class Reserva
    {
        private string strCon = Conexao.getConexao();

        public List<Model.Reserva> Select()
        {
            List<Model.Reserva> lstReserva = new List<Model.Reserva>();
            SqlConnection conexao = new SqlConnection(strCon);
            string query = "select reserva.id, reserva.data, reserva.cliente, cliente.nome from Reserva inner join Cliente on cliente.id=reserva.cliente;";
            SqlCommand cmd = new SqlCommand(query, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Reserva reserva = new Model.Reserva();
 
                    reserva.id = Convert.ToInt32(reader["id"]);
                    reserva.cliente = Convert.ToInt32(reader["cliente"]);
                    reserva.data = Convert.ToDateTime(reader["data"].ToString());
                    reserva.nome = reader["nome"].ToString();
                    lstReserva.Add(reserva);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao consultar reserva;");
            }
            finally
            {
                conexao.Close();
            }
            return lstReserva;
        }

        public void Insert(Model.Reserva reserva)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string query = "Insert into Reserva values ";
            query += " (@data, @cliente);";
            SqlCommand cmd = new SqlCommand(query, conexao);
            cmd.Parameters.AddWithValue("@data", reserva.data);
            cmd.Parameters.AddWithValue("@cliente", reserva.cliente);

            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na inserção da Reserva");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Model.Reserva reserva)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string query = "Update Reserva set data=@data, cliente=@cliente ";
            query += " where id=@id;";
            SqlCommand cmd = new SqlCommand(query, conexao);
            cmd.Parameters.AddWithValue("@data", reserva.data);
            cmd.Parameters.AddWithValue("@cliente", reserva.cliente);
            cmd.Parameters.AddWithValue("@id", reserva.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização da Reserva...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(Model.Reserva reserva)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string query = "Delete from Reserva where id=@id; ";
            SqlCommand cmd = new SqlCommand(query, conexao);
            cmd.Parameters.AddWithValue("@id", reserva.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na exclusão da reserva");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
