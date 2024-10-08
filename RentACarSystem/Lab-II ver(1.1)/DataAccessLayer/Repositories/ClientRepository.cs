using DataAccessLayer.dbConnect;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using CommonLayer.Entities;

namespace DataAccessLayer.Repositories
{
    public class ClientRepository
    {
        private SqlConnect _dbConnect;

        public ClientRepository()
        {
            _dbConnect = new SqlConnect();
        }

        public DataTable GetClients()
        {
            DataTable clientsTable = new DataTable();

            using (var connection = _dbConnect.GetConnection())
            {
                string query = "SELECT ClienteID, Nombre, Telefono, Email FROM Clientes"; // Cambia 'Clients' por 'Clientes'
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                clientsTable.Load(reader);
            }
            return clientsTable;
        }

        public void AddClient(Client client)
        {
            using (var connection = _dbConnect.GetConnection())
            {
                string query = "INSERT INTO Clientes (Nombre, Telefono, Email) VALUES (@Nombre, @Telefono, @Email)"; // Cambia 'Clients' por 'Clientes'
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", client.Name);
                command.Parameters.AddWithValue("@Telefono", client.Telephone);
                command.Parameters.AddWithValue("@Email", client.Email);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void EditClient(Client client)
        {
            using (var connection = _dbConnect.GetConnection())
            {
                string query = "UPDATE Clientes SET Nombre = @Nombre, Telefono = @Telefono, Email = @Email WHERE ClienteID = @ClienteID"; // Cambia 'Clients' por 'Clientes'
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ClienteID", client.ClientID);
                command.Parameters.AddWithValue("@Nombre", client.Name);
                command.Parameters.AddWithValue("@Telefono", client.Telephone);
                command.Parameters.AddWithValue("@Email", client.Email);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void DeleteClient(int clientId)
        {
            using (var connection = _dbConnect.GetConnection())
            {
                string query = "DELETE FROM Clientes WHERE ClienteID = @ClienteID"; // Cambia 'Clients' por 'Clientes'
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ClienteID", clientId);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }
    }
}
