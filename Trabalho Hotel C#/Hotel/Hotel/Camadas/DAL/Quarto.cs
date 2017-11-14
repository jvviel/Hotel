using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Hotel.Camadas.DAL
{
    public class Quarto
    {
        private string strCon = Conexao.getConexao();

        public List<Model.Quarto> Select()
        {
            List<Model.Quarto> lstQuartos = new List<Model.Quarto>();
            SqlConnection conexao = new SqlConnection(strCon);

            string query = "Select * from Quarto";
            SqlCommand cmd = new SqlCommand(query, conexao);
            conexao.Open();

            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    Model.Quarto quarto = new Model.Quarto();
                    quarto.id = Convert.ToInt32(reader["id"]);
                    quarto.descricao = reader["descricao"].ToString();
                    quarto.valor = Convert.ToSingle(reader["valor"].ToString());
                    quarto.status = Convert.ToChar(reader["status"].ToString());
                    lstQuartos.Add(quarto);
                }
            }
            catch
            {
                Console.WriteLine("Erro na consulta de Quartos");
            }
            finally
            {
                conexao.Close();
            }


            return lstQuartos;

        }

        public List<Model.Quarto> SelectById(int id)
        {
            List<Model.Quarto> lstQuartos = new List<Model.Quarto>();
            SqlConnection conexao = new SqlConnection(strCon);

            string query = "Select * from Quarto where id=@id;";
            SqlCommand cmd = new SqlCommand(query, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            conexao.Open();

            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    Model.Quarto quarto = new Model.Quarto();
                    quarto.id = Convert.ToInt32(reader["id"]);
                    quarto.descricao = reader["descricao"].ToString();
                    quarto.valor = Convert.ToSingle(reader["valor"].ToString());
                    quarto.status = Convert.ToChar(reader["status"].ToString());
                    lstQuartos.Add(quarto);
                }
            }
            catch
            {
                Console.WriteLine("Erro na consulta de Quartos por id");
            }
            finally
            {
                conexao.Close();
            }


            return lstQuartos;

        }

        public List<Model.Quarto> SelectByNome(string descricao)
        {
            List<Model.Quarto> lstQuartos = new List<Model.Quarto>();
            SqlConnection conexao = new SqlConnection(strCon);

            string query = "Select * from Quarto where (descricao like @descricao);";
            SqlCommand cmd = new SqlCommand(query, conexao);
            cmd.Parameters.AddWithValue("@descricao", descricao.Trim() + "%");
            conexao.Open();

            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    Model.Quarto quarto = new Model.Quarto();
                    quarto.id = Convert.ToInt32(reader["id"]);
                    quarto.descricao = reader["descricao"].ToString();
                    quarto.valor = Convert.ToSingle(reader["valor"].ToString());
                    quarto.status = Convert.ToChar(reader["status"].ToString());
                    lstQuartos.Add(quarto);
                }
            }
            catch
            {
                Console.WriteLine("Erro na consulta de Quartos por Descricao");
            }
            finally
            {
                conexao.Close();
            }


            return lstQuartos;

        }

        public void Insert(Model.Quarto quarto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string query = "insert into Quarto values ";
            query += " (@descricao, @valor, @status); ";
            SqlCommand cmd = new SqlCommand(query, conexao);
            cmd.Parameters.AddWithValue("@descricao", quarto.descricao);
            cmd.Parameters.AddWithValue("@valor", quarto.valor);
            cmd.Parameters.AddWithValue("@status", quarto.status);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro ao inserir Quarto");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Model.Quarto quarto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string query = "Update Quarto set descricao=@descricao, valor=@valor, status=@status ";
            query += "where id=@id;";
            SqlCommand cmd = new SqlCommand(query, conexao);
            cmd.Parameters.AddWithValue("@id", quarto.id);
            cmd.Parameters.AddWithValue("@descricao", quarto.descricao);
            cmd.Parameters.AddWithValue("@valor", quarto.valor);
            cmd.Parameters.AddWithValue("@status", quarto.status);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro ao atualizar Quarto");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(Model.Quarto quarto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string query = "Delete from Quarto where id=@id;";
            SqlCommand cmd = new SqlCommand(query, conexao);
            cmd.Parameters.AddWithValue("@id", quarto.id);

            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro ao deletar o quarto");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
