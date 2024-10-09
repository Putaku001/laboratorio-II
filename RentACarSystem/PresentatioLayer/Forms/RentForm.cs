﻿using BusinessLayer.Services;
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
    public partial class RentForm : Form
    {
        private RentService _rentService;
        public RentForm()
        {
            InitializeComponent();
            _rentService = new RentService();
            LoadCarsTable();
        }

        public void LoadCarsTable()
        {
            CarscomboBox.DataSource = _rentService.GetCars();
            CarscomboBox.DisplayMember = "CarFullName";
            CarscomboBox.ValueMember = "VehiculoID";

        }
        private void clientsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientForm clientForm = new ClientForm();
            clientForm.Show();

        }

        private void carsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CarsForm carsForm = new CarsForm();
            carsForm.Show();
        }

        private void RentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
