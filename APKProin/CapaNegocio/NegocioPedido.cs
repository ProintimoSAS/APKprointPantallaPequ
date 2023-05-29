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
    public class NegocioPedido
    {
        AccesoDatosPedido objAccesoDatosPedido = new AccesoDatosPedido();
        public DataTable obtenerPedido(string nombreCliente)
        {
            return objAccesoDatosPedido.ObtenerPedidos(nombreCliente);

        }
        public void InsertarCliente(string codigo, string nombreCliente)
        {
            objAccesoDatosPedido.InsertarPedido(codigo, nombreCliente);
        }
    }
}
