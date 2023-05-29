using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Pedido
    {
        public int id { get; set; }
        public string Codigo { get; set; }
        public int idCliente { get; set; }

    }
}
