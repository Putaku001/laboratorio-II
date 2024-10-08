﻿using CommonLayer.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentatioLayer.Forms
{
    public partial class ClientForm : Form
    {
        private ClientRepository _clientRepository;

        public ClientForm()
        {
            InitializeComponent();
            _clientRepository = new ClientRepository();
            LoadClients();
        }

        private void LoadClients()
        {
            DataTable clientsTable = _clientRepository.GetClients();
            clientDataGridView.DataSource = clientsTable;

            clientDataGridView.Columns["ClienteID"].HeaderText = "ID";
            clientDataGridView.Columns["Nombre"].HeaderText = "Nombre";
            clientDataGridView.Columns["Telefono"].HeaderText = "Teléfono";
            clientDataGridView.Columns["Email"].HeaderText = "Email";
        }
        private void clientDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (clientDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = clientDataGridView.SelectedRows[0];
                nameTextBox.Text = selectedRow.Cells["Nombre"].Value.ToString();
                phoneTextBox.Text = selectedRow.Cells["Telefono"].Value.ToString();
                emailTextBox.Text = selectedRow.Cells["Email"].Value.ToString();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Client client = new Client
            {
                Name = nameTextBox.Text,
                Telephone = phoneTextBox.Text,
                Email = emailTextBox.Text
            };

            _clientRepository.AddClient(client);
            LoadClients();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (clientDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = clientDataGridView.SelectedRows[0];
                Client client = new Client
                {
                    ClientID = Convert.ToInt32(selectedRow.Cells["ClienteID"].Value),
                    Name = nameTextBox.Text,
                    Telephone = phoneTextBox.Text,
                    Email = emailTextBox.Text
                };

                _clientRepository.EditClient(client);
                LoadClients();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (clientDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = clientDataGridView.SelectedRows[0];
                int clientId = Convert.ToInt32(selectedRow.Cells["ClienteID"].Value);

                var result = MessageBox.Show("¿Está seguro de que desea eliminar este cliente?", "Confirmar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _clientRepository.DeleteClient(clientId);
                    LoadClients();
                }
            }
        }

    }
}

