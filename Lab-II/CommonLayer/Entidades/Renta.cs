using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entidades
{
    public class Renta
    {
        public int RentaID { get; set; }
        public int ClienteID { get; set; }
        public int VehiculoID { get; set; }
        public DateTime FechaRenta { get; set; }
        public DateTime? FechaDevolucion { get; set; }
    }
}
