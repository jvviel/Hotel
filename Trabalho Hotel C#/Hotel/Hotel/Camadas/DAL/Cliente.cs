using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Hotel.Camadas.DAL
{
    public class Cliente
    {
        private string strCon = Conexao.getConexao();
        
        public List<Model.Cliente> Select()
        {
            List<Model.Cliente> lstClientes = new List<Model.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);

            string query = "Select * from Cliente";
            SqlCommand cmd = new SqlCommand(query, conexao);
            conexao.Open();

            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    Model.Cliente cliente = new Model.Cliente();
                    cliente.id = Convert.ToInt32(reader["id"]);
                    cliente.nome = reader["nome"].ToString();
                    cliente.endereco = reader["endereco"].ToString();
                    cliente.cidade = reader["cidade"].ToString();
                    cliente.estado = reader["estado"].ToString();
                    cliente.fone = reader["fone"].ToString();
                    lstClientes.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Erro na consulta de clientes");
            }
            finally
            {
                conexao.Close();
            }


            return lstClientes;
            
        }

        public List<Model.Cliente> SelectById(int id)
        {
            List<Model.Cliente> lstClientes = new List<Model.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);

            string query = "Select * from Cliente where id=@id;";
            SqlCommand cmd = new SqlCommand(query, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            conexao.Open();

            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    Model.Cliente cliente = new Model.Cliente();
                    cliente.id = Convert.ToInt32(reader["id"]);
                    cliente.nome = reader["nome"].ToString();
                    cliente.endereco = reader["endereco"].ToString();
                    cliente.cidade = reader["cidade"].ToString();
                    cliente.estado = reader["estado"].ToString();
                    cliente.fone = reader["fone"].ToString();
                    lstClientes.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Erro na consulta de clientes por id");
            }
            finally
            {
                conexao.Close();
            }


            return lstClientes;

        }

        public List<Model.Cliente> SelectByNome(string nome)
        {
            List<Model.Cliente> lstClientes = new List<Model.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);

            string query = "Select * from Cliente where (nome like @nome);";
            SqlCommand cmd = new SqlCommand(query, conexao);
            cmd.Parameters.AddWithValue("@nome", nome.Trim() + "%");
            conexao.Open();

            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    Model.Cliente cliente = new Model.Cliente();
                    cliente.id = Convert.ToInt32(reader["id"]);
                    cliente.nome = reader["nome"].ToString();
                    cliente.endereco = reader["endereco"].ToString();
                    cliente.cidade = reader["cidade"].ToString();
                    cliente.estado = reader["estado"].ToString();
                    cliente.fone = reader["fone"].ToString();
                    lstClientes.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Erro na consulta de clientes por nome");
            }
            finally
            {
                conexao.Close();
            }


            return lstClientes;

        }

        public void Insert (Model.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string query = "insert into Cliente values ";
            query += " (@nome, @endereco, @cidade, @estado, @fone); ";
            SqlCommand cmd = new SqlCommand(query, conexao);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@cidade", cliente.cidade);
            cmd.Parameters.AddWithValue("@estado", cliente.estado);
            cmd.Parameters.AddWithValue("@fone", cliente.fone);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro ao inserir cliente");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Model.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string query = "Update Cliente set nome=@nome, endereco=@endereco, cidade=@cidade, estado=@estado, fone=@fone ";
            query += "where id=@id;";
            SqlCommand cmd = new SqlCommand(query, conexao);
            cmd.Parameters.AddWithValue("@id", cliente.id);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@cidade", cliente.cidade);
            cmd.Parameters.AddWithValue("@estado", cliente.estado);
            cmd.Parameters.AddWithValue("@fone", cliente.fone);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro ao inserir atualizar cliente");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(Model.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string query = "Delete from Cliente where id=@id;";
            SqlCommand cmd = new SqlCommand(query, conexao);
            cmd.Parameters.AddWithValue("@id", cliente.id);
           
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro ao inserir cliente");
            }
            finally
            {
                conexao.Close();
            }
        }

    }
}
