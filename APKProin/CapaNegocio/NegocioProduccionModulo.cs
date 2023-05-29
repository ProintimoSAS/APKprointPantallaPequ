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
    public  class NegocioProduccionModulo
    {
        AccesoDatosProduccionModulo objAccesoDatosProduccionModulo = new AccesoDatosProduccionModulo();
        public DataTable obtenerProduccionModulo(string codigoOrdenProduccion)
        {
            return objAccesoDatosProduccionModulo.ObtenerProduccionModulo(codigoOrdenProduccion);
        }
        public DataTable obtenerProduccionModuloPorFecha(DateTime fecha, string nombreModulo)
        {
            return objAccesoDatosProduccionModulo.ObtenerProduccionModuloPorFecha(fecha, nombreModulo);
        }
        public DataTable obtenerProduccionModuloPorFechaYOrden(DateTime fecha, string codigoOrden)
        {
            return objAccesoDatosProduccionModulo.ObtenerProduccionModuloPorFechaYOrden(fecha, codigoOrden);
        }
        public void InsertarProduccionModulo(ProduccionModulo produccionModulo, string codigoOrdenDeProduccion)
        {
            objAccesoDatosProduccionModulo.InsertarProduccionModulo(produccionModulo, codigoOrdenDeProduccion);
        }
        public void EliminarProduccionModulo(string codigoOrdenProduccion)
        {
            objAccesoDatosProduccionModulo.EliminarUltimoDatoProduccionModulo(codigoOrdenProduccion);
        }
        public float ObtenerTotalUnidadesEsperadasPorNave(string nave, DateTime fecha)
        {
            return objAccesoDatosProduccionModulo.ObtenerTotalUnidadesEsperadasPorNave(nave, fecha);
        }
        public int ObtenerTotalUnidadesFabricadasPorNave(string nave, DateTime fecha)
        {
            return objAccesoDatosProduccionModulo.ObtenerTotalUnidadesFabricadasPorNave(nave, fecha);
        }
        public float ObtenerTotalUnidadesEsperadasReales(string nave, DateTime fecha)
        {
            return objAccesoDatosProduccionModulo.ObtenerTotalUnidadesEsperadasRealesPorNave(nave, fecha);
        }
        public DataTable ObtenerComentFabriAcumRealPorFecha(DateTime fecha, string modulo)
        {
            return objAccesoDatosProduccionModulo.ObtenerComentFabriAcumRealPorFecha(fecha, modulo);
        }
    }
}
