using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class OrdenDeProduccion
    {
        public int id { get; set; }
        public string Codigo { get; set; }
        public int UnidadesAFabricar { get; set; }
        public float Sam { get; set; }
        public string Talla { get; set; }
        public int idModulo { get; set; }
        public int idReferencia { get; set; }

        /*public OrdenDeProduccion(string codigo, int unidadesAFabricar, float sam, string talla, int idModulo, int idReferencia)
        {
            Codigo = codigo;
            UnidadesAFabricar = unidadesAFabricar;
            Sam = sam;
            Talla = talla;
            this.idModulo = idModulo;
            this.idReferencia = idReferencia;
        }

        public OrdenDeProduccion CrearOrdenDeProduccion(string codigo, int unidadesAFabricar, float sam, string talla, int idModulo, int idReferencia) 
        {
            return new OrdenDeProduccion( codigo, unidadesAFabricar, sam, talla, idModulo, idReferencia);
        }*/

    }
}
