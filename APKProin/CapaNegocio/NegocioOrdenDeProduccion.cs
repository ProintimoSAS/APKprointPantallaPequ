using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioOrdenDeProduccion
    {
        AccesoDatosOrdenDeProduccion objAccesoDatosOrdenDeProduccion = new AccesoDatosOrdenDeProduccion();
        public DataTable obtenerOrdenesDeProduccion(string nombreModulo)
        {
            return objAccesoDatosOrdenDeProduccion.ObtenerOrdenPorModulo(nombreModulo);
        }
        public void InsertarOrdenDeProduccion(OrdenDeProduccion ordenDeProduccion, string nombreModulo, string codigoReferencia)
        {
            objAccesoDatosOrdenDeProduccion.InsertarOrdenDeProduccion(ordenDeProduccion, nombreModulo, codigoReferencia);
        }
        public string obtenerCodigoOrden(string nombreModulo)
        {
            return objAccesoDatosOrdenDeProduccion.ObtenerCodigoOrdenPorModulo(nombreModulo);
        }

    }
}
