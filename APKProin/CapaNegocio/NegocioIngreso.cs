using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocio
{
    public class NegocioIngreso
    {

        CapaAccesoDatos.AccesoDatosIngreso objDatos = new CapaAccesoDatos.AccesoDatosIngreso();

        public DataTable DatosNegocio(CapaEntidad.EntidadIngreso objEntidad)
        {
            return objDatos.ValidarUsuario(objEntidad);

        }
    }
}
