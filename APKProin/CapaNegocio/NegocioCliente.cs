using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class NegocioCliente
    {
        AccesoDatosCliente objAccesoDatosCliente = new AccesoDatosCliente();        
        public DataTable obtenerClientes()
        {
            return objAccesoDatosCliente.ObtenerClientes();

        }
        /*public void InsertarCliente(Cliente cliente)
        {
            objAccesoDatosCliente.InsertarCliente(cliente);
        }*/
    }
}
