using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer.Repositorio;

namespace BusinessLayer.Servicio
{
    public class CarService
    {
        private RepositorioDeVehiculos _RepositorioDeVehiculos;

        public CarService()
        {
            _RepositorioDeVehiculos = new RepositorioDeVehiculos();
        }
        
    }
}
