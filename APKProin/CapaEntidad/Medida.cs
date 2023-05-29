using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Medida
    {
        public int id { get; set; }
        public float DescripcionMedida { get; set; }
        public string Tipo { get; set; }
        public float Tolerancia { get; set; }
        public int idPartePrenda { get; set; }
        public int idTalla { get; set; }
    }
}
