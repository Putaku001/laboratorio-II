using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer.Repositories;


namespace BusinessLayer.Services
{
    public class CarService
    {
        private CarRepository _carRepository;

        public CarService()
        {
            _carRepository = new CarRepository();
        }

        public DataTable GetAllCars()
        {
            return _carRepository.GetCars();
        }
            

        
    }
}
