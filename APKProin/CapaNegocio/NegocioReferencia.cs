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
    public class NegocioReferencia
    {
        AccesoDatosReferencia objAccesoDatosReferencia = new AccesoDatosReferencia();
        public DataTable obtenerReferencia(string codigoOrdenProduccion)
        {
            return objAccesoDatosReferencia.ObtenerReferenciaPorOrden(codigoOrdenProduccion);
        }
        public void InsertarReferencia(Referencia referencia, int idPedido)
        {
            objAccesoDatosReferencia.InsertarReferencia(referencia, idPedido);
        }

        public DataTable ObtenerReferenciaPorCodigo(string codigoReferencia)
        {
            return objAccesoDatosReferencia.ObtenerReferenciaPorCodigo(codigoReferencia);
        }
    }
}
