using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Referencia
    {
        public int id { get; set; }
        public string Codigo { get; set; }
        public string Color { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int UnidadesTotalesAFabricar { get; set; }
        public int idPedido { get; set; }
    }
}
