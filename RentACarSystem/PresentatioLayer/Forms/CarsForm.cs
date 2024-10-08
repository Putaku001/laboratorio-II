using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Services;
using CommonLayer.Entities;

namespace PresentatioLayer.Forms
{
    public partial class CarsForm : Form
    {
        private CarService _carService;
        public bool isEditing = false;
        public CarsForm()
        {
            InitializeComponent();
            _carService = new CarService();
            LoadCars();
        }

        private void LoadCars()
        {
            CarsDataGridView.DataSource = _carService.GetAllCars();
            CarsDataGridView.Columns[4].ReadOnly = true;
        }

        private void saveCarButton_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                Car car = new Car()
                {
                    Brand = brandTextBox.Text,
                    Model = modelTextBox.Text,
                    Year = int.Parse(yearTextBox.Text),
                    Availability = availabilityCheckBox.Checked,
                    CarId = int.Parse(CarsDataGridView.CurrentRow.Cells[0].Value.ToString())
                };
                _carService.EditCar(car);
                LoadCars();
                isEditing = false;
            }
            else
            {
                Car car = new Car()
                {
                    Brand = brandTextBox.Text,
                    Model = modelTextBox.Text,
                    Year = int.Parse(yearTextBox.Text),
                    Availability = availabilityCheckBox.Checked,
                };
                _carService.AddCar(car);
                LoadCars();
                MessageBox.Show("carro guardado");
            }

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (CarsDataGridView.SelectedRows.Count > 0)
            {
                brandTextBox.Text = CarsDataGridView.CurrentRow.Cells[1].Value.ToString();
                modelTextBox.Text = CarsDataGridView.CurrentRow.Cells[2].Value.ToString();
                yearTextBox.Text = CarsDataGridView.CurrentRow.Cells[3].Value.ToString();
                if (CarsDataGridView.CurrentRow.Cells[4].Value is bool availability)
                {
                    availabilityCheckBox.Checked = availability;
                }
                else
                {
                    availabilityCheckBox.Checked = false;
                }
                isEditing = true;
            }
            else
            {
                MessageBox.Show("seleccione un elemento a editar por favor",
                    "advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (CarsDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("por favor seleccione el carro a eliminar",
                    "advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show("esta seguro de eliminar este dato",
                    "warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int CarId = int.Parse(CarsDataGridView.CurrentRow.Cells[0].Value.ToString());
                    _carService.DeleteCar(CarId);
                    LoadCars();
                }

            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            RentForm rentForm = new RentForm();
            rentForm.Show();
        }

       

    }
}
