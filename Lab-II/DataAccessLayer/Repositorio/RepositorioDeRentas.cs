using CommonLayer.Entidades; 
using DataAccessLayer.dbConnect;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositorio
{
    public class RepositorioDeRentas
    {
        private SqlConnect _dbConnect;

        public RepositorioDeRentas()
        {
            _dbConnect = new SqlConnect();
        }

        public DataTable GetRentas()
        {
            DataTable rentaTable = new DataTable();

            using (var connection = _dbConnect.GetConnection())
            {
                string query = "SELECT RentaID, ClienteID, VehiculoID, FechaRenta, FechaDevolucion FROM Rentas";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                rentaTable.Load(reader);
            }
            return rentaTable;
        }

        public void AddRenta(Renta renta)
        {
            using (var connection = _dbConnect.GetConnection())
            {
                string query = "INSERT INTO Rentas (ClienteID, VehiculoID, FechaRenta, FechaDevolucion) VALUES (@ClienteID, @VehiculoID, @FechaRenta, @FechaDevolucion)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ClienteID", renta.ClienteID);
                command.Parameters.AddWithValue("@VehiculoID", renta.VehiculoID);
                command.Parameters.AddWithValue("@FechaRenta", renta.FechaRenta);
                command.Parameters.AddWithValue("@FechaDevolucion", renta.FechaDevolucion);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void EditRenta(Renta renta)
        {
            using (var connection = _dbConnect.GetConnection())
            {
                string query = "UPDATE Rentas SET ClienteID = @ClienteID, VehiculoID = @VehiculoID, FechaRenta = @FechaRenta, FechaDevolucion = @FechaDevolucion WHERE RentaID = @RentaID";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@RentaID", renta.RentaID);
                command.Parameters.AddWithValue("@ClienteID", renta.ClienteID);
                command.Parameters.AddWithValue("@VehiculoID", renta.VehiculoID);
                command.Parameters.AddWithValue("@FechaRenta", renta.FechaRenta);
                command.Parameters.AddWithValue("@FechaDevolucion", renta.FechaDevolucion);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void DeleteRenta(int rentaId)
        {
            using (var connection = _dbConnect.GetConnection())
            {
                string query = "DELETE FROM Rentas WHERE RentaID = @RentaID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RentaID", rentaId);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }
    }
}
