using System;
using System.Data;
using System.Data.SqlClient;

namespace CRUD_Pessoa
{
    public class PessoaRepository
    {
        private SqlConnection sqlconnect;
        private SqlCommand sqlcommand;
        private SqlDataReader reader;


        private void ConnectDB()
        {
            string connectionString = @"Data Source=ACERDAN;Initial Catalog=master;Integrated Security=True;";
            sqlconnect = new SqlConnection(connectionString);
        }

        public bool AddPessoa(PessoaModel pessoa)
        {
            ConnectDB();
            sqlcommand = new SqlCommand("InsertData", sqlconnect);
            sqlcommand.CommandType = CommandType.StoredProcedure;
            sqlcommand.Parameters.AddWithValue("@Nome", pessoa.Nome);
            sqlcommand.Parameters.AddWithValue("@Renda", pessoa.Renda);
            sqlcommand.Parameters.AddWithValue("@Cpf", pessoa.Cpf);
            sqlcommand.Parameters.AddWithValue("@Data", pessoa.Data);
            sqlconnect.Open();
            int i = sqlcommand.ExecuteNonQuery();
            sqlconnect.Close();

            if (i >= 1)
            {
                return true;

            }
            else
            {
                return false;

            }
        }

        public bool DeletePessoa(PessoaModel pessoa)
        {
            try
            {
                ConnectDB();
                sqlcommand = new SqlCommand("DeleteData", sqlconnect);
                sqlcommand.CommandType = CommandType.StoredProcedure;
                sqlcommand.Parameters.AddWithValue("@Id", pessoa.ClientId);
                sqlcommand.Parameters.AddWithValue("@Nome", pessoa.Nome);
                sqlcommand.Parameters.AddWithValue("@Renda", pessoa.Renda);
                sqlcommand.Parameters.AddWithValue("@Cpf", pessoa.Cpf);
                sqlcommand.Parameters.AddWithValue("@Data", pessoa.Data);
                sqlconnect.Open();
                int i = sqlcommand.ExecuteNonQuery();
                sqlconnect.Close();
                return true;
            }
            catch (Exception er)
            {
                throw new Exception("Erro ao deletar pessoa! - Erro: " + er.Message);
            }            
        }

        public PessoaModel SelectPessoa(PessoaModel pessoa)
        {
            try
            {
                ConnectDB();
                sqlcommand = new SqlCommand("SelectData", sqlconnect);
                sqlcommand.CommandType = CommandType.StoredProcedure;
                sqlcommand.Parameters.AddWithValue("@Id", pessoa.ClientId);
                sqlcommand.Parameters.AddWithValue("@Nome", pessoa.Nome);
                sqlcommand.Parameters.AddWithValue("@Renda", pessoa.Renda);
                sqlcommand.Parameters.AddWithValue("@Cpf", pessoa.Cpf);
                sqlcommand.Parameters.AddWithValue("@Data", pessoa.Data);

                sqlconnect.Open();

                sqlcommand.ExecuteNonQuery();
                using (SqlDataReader rdr = sqlcommand.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        PessoaModel pessoax = new PessoaModel()
                        {
                            ClientId = int.Parse(rdr.GetValue(0).ToString()),
                            Nome = rdr.GetValue(1).ToString(),
                            Renda = decimal.Parse(rdr.GetValue(2).ToString()),
                            Cpf = int.Parse(rdr.GetValue(3).ToString()),
                            Data = rdr.GetValue(4).ToString()
                        };
                        sqlconnect.Close();
                        return pessoax;
                    }
                }
                return null;
            }
            catch (Exception er)
            {
                throw new Exception("Erro ao selecionar pessoa! - Erro: " + er.Message);
            }
        }

        public bool AltPessoa(PessoaModel pessoa)
        {
            try
            {
                ConnectDB();
                sqlcommand = new SqlCommand("AlterData", sqlconnect);
                sqlcommand.CommandType = CommandType.StoredProcedure;
                sqlcommand.Parameters.AddWithValue("@Id", pessoa.ClientId);
                sqlcommand.Parameters.AddWithValue("@Nome", pessoa.Nome);
                sqlcommand.Parameters.AddWithValue("@Renda", pessoa.Renda);
                sqlcommand.Parameters.AddWithValue("@Cpf", pessoa.Cpf);
                sqlcommand.Parameters.AddWithValue("@Data", pessoa.Data);
                sqlconnect.Open();
                int i = sqlcommand.ExecuteNonQuery();
                sqlconnect.Close();
                return true;
            }
            catch (Exception er)
            {
                throw new Exception("Erro ao alterar pessoa! - Erro: " + er.Message);
            }
        }
    }
}
