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
    public class RepositorioDeVehiculos
    {
        private SqlConnect _dbConnect;

        public RepositorioDeVehiculos()
        {
            _dbConnect = new SqlConnect();
        }

        public DataTable GetVehiculos()
        {
            DataTable vehiculoTable = new DataTable();

            using (var connection = _dbConnect.GetConnection())
            {
                string query = "SELECT VehiculoID, Marca, Modelo, Año, Disponibilidad FROM Vehiculos";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                vehiculoTable.Load(reader);
            }
            return vehiculoTable;
        }
        public void addVehiculo(Vehiculos vehiculos)
        {
            using (var connection = _dbConnect.GetConnection())
            {
                string query = "INSERT INTO Vehiculos (Marca, Modelo, Año, Disponibilidad) VALUES (@Marca, @Modelo, @Año, @Disponibilidad)D";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Marca", vehiculos.Marca);
                command.Parameters.AddWithValue("@Modelo", vehiculos.Modelo);
                command.Parameters.AddWithValue("@Año", vehiculos.Año);
                command.Parameters.AddWithValue("@Disponibilidad", vehiculos.Disponibilidad);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }
        public void EditVehiculo(Vehiculos vehiculos)
        {
            using (var connection = _dbConnect.GetConnection())
            {
                string query = "UPDATE Vehiculos SET Marca = @Marca, Modelo = @Modelo, Año = @Año, Disponibilidad = @Disponibilidad WHERE VehiculoID = @VehiculoID";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@VehiculoID", vehiculos.VehiculoID);
                command.Parameters.AddWithValue("@Marca", vehiculos.Marca);
                command.Parameters.AddWithValue("@Modelo", vehiculos.Modelo);
                command.Parameters.AddWithValue("@Año", vehiculos.Año);
                command.Parameters.AddWithValue("@Disponibilidad", vehiculos.Disponibilidad);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }
        public void DeleteVehiculo(int VehiculoId)
        {
            using (var connection = _dbConnect.GetConnection())
            {
                string query = "DELETE FROM Vehiculos WHERE VehiculoID = @VehiculoID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@VehiculoID", VehiculoId);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }
    }
}
