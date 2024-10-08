﻿using System;
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
            _connectionString = "Data Source=.;Initial Catalog=SistemaRentaAutos;Integrated Security=True;Encrypt=False";
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
 