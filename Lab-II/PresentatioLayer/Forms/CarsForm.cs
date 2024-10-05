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

namespace PresentatioLayer.Forms
{
    public partial class CarsForm : Form
    {
        private CarService _carService;
        public CarsForm()
        {
            InitializeComponent();
            _carService = new CarService();
            LoadCars();
        }

        private void LoadCars()
        {
            CarsDataGridView.DataSource= _carService.GetAllCars();
        }
    }
}
