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
    public class NegocioModulo
    {
        AccesoDatosModulo objAccesoDatosModulo = new AccesoDatosModulo();
        public DataTable obtenerModulo()
        {
            return objAccesoDatosModulo.ObtenerModulos();
        }
        public void InsertarModulo(string nombre)
        {
            objAccesoDatosModulo.InsertarModulo(nombre);
        }
        public string ObtenerEficienciaAcumuladaPorNave(string nave)
        {
            return objAccesoDatosModulo.ObtenerEficienciaAcumuladaPorNave(nave);
        }
    }
}
