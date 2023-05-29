using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Empleado
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string Area { get; set; }

        public Empleado(string nombre, string cargo, string area)
        {
            Nombre = nombre;
            Cargo = cargo;
            Area = area;
        }


    }
}
