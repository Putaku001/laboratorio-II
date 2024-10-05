using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entidades;
using Microsoft.Data.SqlClient;
using DataAccessLayer.dbConnect;
using System.Data;

namespace DataAccessLayer.RepositorioDeClientes
{
    public class RepositorioDeClientes
    {
        private SqlConnect _dbConnect;

        public RepositorioDeClientes()
        {
            _dbConnect = new SqlConnect();
        }
        public DataTable GetVehiculo()
        {
            DataTable VehiculoTable = new DataTable();
            using (var connection = _dbConnect.GetConnection())
            {
                string query = @"SELECT VehiculoId, Marca, Modelo FROM Vehiculos";
                using (var sqlcommand = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = sqlcommand.ExecuteReader())
                    {
                        VehiculoTable.Load(reader);
                    }
                }
            }
            return VehiculoTable;
        }

    }
}
