using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entities;
using System.Data;

namespace DAL
{
    public class ClientsDAL
    {
        //DateTime daytime = new DateTime();

        private string connectionString;
        private SqlConnection conn;
        DateTime daytime = DateTime.Now;

        public ClientsDAL()
        {
            connectionString = Connection.getConnectionString();
        }

        public int InsertClient(Client client)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    int affectedRows;
                    SqlCommand cmdInsert =
                        new SqlCommand("dbo.spInsertClient", conn);
                    cmdInsert.CommandType = CommandType.StoredProcedure;
                    cmdInsert.Parameters.AddWithValue("@Name", client.Name);
                    cmdInsert.Parameters.AddWithValue("@F_Surname", client.firstSurname);
                    cmdInsert.Parameters.AddWithValue("@S_Surname", client.secondSurname);
                    cmdInsert.Parameters.AddWithValue("@DATE", daytime.Date.ToString());

                    conn.Open();

                    affectedRows = cmdInsert.ExecuteNonQuery();
                    //conn.Close();

                    return affectedRows;
                }
            }
            catch
            {
                throw;
            }
        }
        public int DeleteClientById(int idCliente)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    int affectedRows;
                    SqlCommand cmdInsert =
                        new SqlCommand("dbo.spDeleteClientById", conn);
                    cmdInsert.CommandType = CommandType.StoredProcedure;
                    cmdInsert.Parameters.AddWithValue("@id", idCliente);

                    conn.Open();

                    affectedRows = cmdInsert.ExecuteNonQuery();
                    //conn.Close();

                    return affectedRows;
                }
            }
            catch
            {
                throw;
            }
        }

        public DataTable SearchClientsByName(string clientName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                DataTable data = new DataTable();

                SqlCommand cmdSearchByName =
                    new SqlCommand("dbo.spShowClientByNameOrderDesc", conn);
                cmdSearchByName.CommandType = CommandType.StoredProcedure;
                cmdSearchByName.Parameters.AddWithValue("@name", clientName);
                conn.Open();

                SqlDataReader RegisterData = cmdSearchByName.ExecuteReader();

                data.Load(RegisterData);

                return data;
            }
        }
        public DataTable SearchClientsById(int clientId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                DataTable data = new DataTable();

                SqlCommand cmdSearchById =
                    new SqlCommand("dbo.spShowClientById", conn);
                cmdSearchById.CommandType = CommandType.StoredProcedure;
                cmdSearchById.Parameters.AddWithValue("@id", clientId);
                conn.Open();

                SqlDataReader RegisterData = cmdSearchById.ExecuteReader();

                data.Load(RegisterData);

                return data;
            }
        }
        public DataTable SearchAllClients()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                DataTable data = new DataTable();

                SqlCommand cmdShowAllClients =
                    new SqlCommand("dbo.spShowAllClients", conn);
                cmdShowAllClients.CommandType = CommandType.StoredProcedure;

                conn.Open();

                SqlDataReader RegisterData = cmdShowAllClients.ExecuteReader();

                data.Load(RegisterData);

                return data;
            }
        }

        public DataTable UpdateUser(string id, string name, string fSurname, string sSurname)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                DataTable data = new DataTable();

                SqlCommand cmdUpdateUser =
                    new SqlCommand("dbo.spUpdateUser", conn);
                cmdUpdateUser.CommandType = CommandType.StoredProcedure;
                cmdUpdateUser.Parameters.AddWithValue("@id", id);
                cmdUpdateUser.Parameters.AddWithValue("@name", name);
                cmdUpdateUser.Parameters.AddWithValue("@fSurname", fSurname);
                cmdUpdateUser.Parameters.AddWithValue("@sSurname", sSurname);
                conn.Open();

                SqlDataReader RegisterData = cmdUpdateUser.ExecuteReader();

                data.Load(RegisterData);

                return data;
            }
        }


    }
}
