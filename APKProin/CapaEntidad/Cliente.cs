using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cliente
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string NIT { get; set; }

        public Cliente(string nombre, string nit)
        {
            Nombre = nombre;
            NIT = nit;
        }

        public Cliente CrearCliente(string nombre, string nit)
        {
            return new Cliente(nombre, nit);
        }
    }
}
