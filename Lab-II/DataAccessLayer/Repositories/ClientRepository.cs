using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities;
using Microsoft.Data.SqlClient;
using DataAccessLayer.dbConnect;
using System.Data;

namespace DataAccessLayer.Repositories
{
    public class ClientRepository
    {
        private SqlConnect _dbConnect;

        public ClientRepository()
        {
            _dbConnect = new SqlConnect();
        }
        public DataTable GetClient()
        {
            DataTable ClientsTable = new DataTable();

            using (var connection = _dbConnect.GetConnection())
            {
                string query = "SELECT ClientId, Nombre, Telefono,Email FROM Clientes";
                using (var sqlcommand = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = sqlcommand.ExecuteReader())
                    {
                        ClientsTable.Load(reader);
                    }
                }
            }
            return ClientsTable;
        }

    }
}
