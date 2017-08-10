using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CrudBasico
{
    public class Dados
    {
        //String de conexão
        public string strConexao = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        //Constantes SQL
        public const string strDelete = "DELETE FROM Clientes WHERE IdCliente = @IdCliente";
        public const string strInsert = "INSERT INTO Clientes (NOME,ENDERECO, SEXO, TELEFONE,ATIVO,DATACADASTRO) VALUES " +
            "(@Nome, @Endereco, @Sexo, @Telefone, @Ativo, @DataCadastro)";
        public const string strSelectLogin = "Select IdLogin, Login, Senha FROM Login WHERE Login = @Login AND Senha = @Senha";
        public const string strSelect = "SELECT IdCliente, Nome, Endereco, Telefone, Sexo, Ativo, DataCadastro FROM Clientes" ;
        public const string strUpdate = "UPDATE Clientes SET Nome = @Nome, Endereco = @Endereco, Sexo = @Sexo, Telefone = @Telefone, Ativo = @Ativo, DataCadastro = @DataCadastro WHERE IdCliente = @IdCliente";

        public class Clientes
        {
            public string IdCliente { get; set; }
            public string Nome { get; set; }
            public string Endereco { get; set; }
            public string Telefone { get; set; }
            public string Sexo { get; set; }
            public bool Ativo { get; set; }
            public DateTime DataCadastro { get; set; }
        }

        public class LoginModelo
        {
            public int IdLogin { get; set; }
            public string Login { get; set; }
            public string Senha { get; set; }
        }
        #region Métodos
        public void Atualizar(int IdCliente, string Nome, string Endereco, string Telefone, string Sexo, bool Ativo, DateTime DataCadastro)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objCommand = new SqlCommand(strUpdate, objConexao))
                {
                    objCommand.Parameters.AddWithValue("IdCliente", IdCliente);
                    objCommand.Parameters.AddWithValue("@Nome", Nome);
                    objCommand.Parameters.AddWithValue("@Endereco", Endereco);
                    objCommand.Parameters.AddWithValue("@Sexo", Sexo);
                    objCommand.Parameters.AddWithValue("@Telefone", Telefone);
                    objCommand.Parameters.AddWithValue("@Ativo", Ativo);
                    objCommand.Parameters.AddWithValue("@DataCadastro", DataCadastro);

                    objConexao.Open();
                    objCommand.ExecuteNonQuery();
                    objConexao.Close();

                }
            }

        }

        public List<Clientes> Consultar()
        {
            List<Clientes> lstClientes = new List<Clientes>();
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objCommand = new SqlCommand(strSelect, objConexao))
                {
                    objConexao.Open();
                    SqlDataReader objDataReader;
                    objDataReader = objCommand.ExecuteReader();

                    if(objDataReader.HasRows)
                    {
                        while (objDataReader.Read())
                        {
                            Clientes objClientes = new Clientes();
                            objClientes.IdCliente = objDataReader["IdCliente"].ToString();
                            objClientes.Nome = objDataReader["Nome"].ToString();
                            objClientes.Endereco = objDataReader["Endereco"].ToString();
                            objClientes.Telefone = objDataReader["Telefone"].ToString();
                            objClientes.Sexo = objDataReader["Sexo"].ToString();

                            if (objDataReader["Ativo"].ToString().Equals("0"))
                                objClientes.Ativo = false;
                            else
                                objClientes.Ativo = true;

                            objClientes.DataCadastro = Convert.ToDateTime(objDataReader["DataCadastro"].ToString());
                            lstClientes.Add(objClientes);
                        }
                        objDataReader.Close();
                    }
                    objConexao.Close(); 
                }
            }
            return lstClientes; 
        }

        public List<LoginModelo> ConsultarLogin(string Login, string Senha)
        {
            List<LoginModelo> lstLogin = new List<LoginModelo>();
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objCommand = new SqlCommand(strSelectLogin, objConexao))
                {
                    objCommand.Parameters.AddWithValue("@Login", Login);
                    objCommand.Parameters.AddWithValue("@Senha", Senha);
                    objConexao.Open();
                    SqlDataReader objDataReader;
                    objDataReader = objCommand.ExecuteReader();

                    if (objDataReader.HasRows)
                    {
                        while (objDataReader.Read())
                        {
                            LoginModelo objLogin = new LoginModelo();
                            objLogin.IdLogin = Convert.ToInt32(objDataReader["IdLogin"].ToString());
                            objLogin.Login = objDataReader["Login"].ToString();
                            objLogin.Senha = objDataReader["Senha"].ToString();
                            lstLogin.Add(objLogin);
                        }
                        objDataReader.Close();
                    }
                    objConexao.Close();
                }
            }
            return lstLogin;
        }
        public void Excluir(int IdCliente)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objCommand = new SqlCommand(strDelete, objConexao))
                {
                    objCommand.Parameters.AddWithValue("IdCliente", IdCliente);

                    objConexao.Open();
                    objCommand.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
        }
        public void Gravar(string Nome, string Endereco, string Telefone, string Sexo, bool Ativo, DateTime DataCadastro)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objCommand = new SqlCommand(strInsert, objConexao))
                {
                    objCommand.Parameters.AddWithValue("@Nome", Nome);
                    objCommand.Parameters.AddWithValue("@Endereco", Endereco);
                    objCommand.Parameters.AddWithValue("@Sexo", Sexo);
                    objCommand.Parameters.AddWithValue("@Telefone", Telefone);
                    objCommand.Parameters.AddWithValue("@Ativo", Ativo);
                    objCommand.Parameters.AddWithValue("@DataCadastro", DataCadastro);

                    objConexao.Open();
                    objCommand.ExecuteNonQuery();
                    objConexao.Close(); 

                }
            }

        }
        #endregion 
    }
}
