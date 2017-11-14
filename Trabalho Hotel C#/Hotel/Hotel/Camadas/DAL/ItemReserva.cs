using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Hotel.Camadas.DAL
{
    public class ItemReserva
    {
        private string strCon = Conexao.getConexao();

        public List<Model.ItemReserva> Select()
        {
            List<Model.ItemReserva> lstItemReserva = new List<Model.ItemReserva>();
            SqlConnection conexao = new SqlConnection(strCon);
            string query = "select * from ItemReserva;";
            SqlCommand cmd = new SqlCommand(query, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {     
                    Model.ItemReserva itemReserva = new Model.ItemReserva();
                    itemReserva.id = Convert.ToInt32(reader["id"]);
                    itemReserva.reserva = Convert.ToInt32(reader["reserva"]);
                    itemReserva.quarto = Convert.ToInt32(reader["quarto"]);
                    itemReserva.entrada = Convert.ToDateTime(reader["entrada"].ToString());
                    itemReserva.valor = Convert.ToSingle(reader["valor"].ToString());
                    itemReserva.dias = Convert.ToInt32(reader["dias"].ToString());
                    lstItemReserva.Add(itemReserva);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao consultar Item Reserva");
            }
            finally
            {
                conexao.Close();
            }
            return lstItemReserva;
        }

        public List<Model.ItemReserva> SelectByReserva(int reserva)
        {
            List<Model.ItemReserva> lstItemReserva = new List<Model.ItemReserva>();
            SqlConnection conexao = new SqlConnection(strCon);
            string query = "select * from ItemReserva where reserva=@reserva;";
            SqlCommand cmd = new SqlCommand(query, conexao);
            cmd.Parameters.AddWithValue("@reserva", reserva);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    //instanciando objeto ItemLocacao     
                    Model.ItemReserva ItemReserva = new Model.ItemReserva();
                    //carregar os dado no objeto ItemLocacao -- popular objeto
                    ItemReserva.id = Convert.ToInt32(reader["id"]);
                    ItemReserva.reserva = Convert.ToInt32(reader["reserva"]);
                    ItemReserva.quarto = Convert.ToInt32(reader["quarto"]);
                    ItemReserva.entrada = Convert.ToDateTime(reader["entrada"].ToString());
                    ItemReserva.valor = Convert.ToSingle(reader["valor"].ToString());
                    ItemReserva.dias = Convert.ToInt32(reader["dias"].ToString());
                    lstItemReserva.Add(ItemReserva);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Item Reserva por reserva....;");
            }
            finally
            {
                conexao.Close();
            }
            return lstItemReserva;
        }

        public void Insert(Model.ItemReserva itemReserva)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string query = "Insert into ItemReserva values ";
            query += " (@reserva ,@quarto, @entrada, @valor, @dias);";
            SqlCommand cmd = new SqlCommand(query, conexao);
            cmd.Parameters.AddWithValue("@reserva", itemReserva.reserva);
            cmd.Parameters.AddWithValue("@quarto", itemReserva.quarto);
            cmd.Parameters.AddWithValue("@entrada", itemReserva.entrada);
            cmd.Parameters.AddWithValue("@valor", itemReserva.valor);
            cmd.Parameters.AddWithValue("@dias", itemReserva.dias);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro inserção de Item Reserva");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Model.ItemReserva itemReserva)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string query = "Update ItemReserva set reserva=@reserva, quarto=@quarto, ";
            query += "entrega=@entrega, valor=@valor, dias=@dias ";
            query += " where id=@id;";
            SqlCommand cmd = new SqlCommand(query, conexao);
            cmd.Parameters.AddWithValue("@locacao", itemReserva.reserva);
            cmd.Parameters.AddWithValue("@produto", itemReserva.quarto);
            cmd.Parameters.AddWithValue("@entrega", itemReserva.entrada);
            cmd.Parameters.AddWithValue("@valor", itemReserva.valor);
            cmd.Parameters.AddWithValue("@dias", itemReserva.dias);
            cmd.Parameters.AddWithValue("@id", itemReserva.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Item Reserva");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(Model.ItemReserva itemReserva)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string query = "Delete from ItemReserva where id=@id; ";
            SqlCommand cmd = new SqlCommand(query, conexao);
            cmd.Parameters.AddWithValue("@id", itemReserva.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na remocao Item Reserva");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
