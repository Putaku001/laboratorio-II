using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System;


namespace DataAccessLayer.dbConnect
{
    public class SqlConnect
    {
        private readonly string _connectionString;


        public SqlConnect()
        {
            _connectionString = "Data Source=DESKTOP-OKJJS3Y\\SQLEXPRESS;Initial Catalog=RentaVehiculosDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
