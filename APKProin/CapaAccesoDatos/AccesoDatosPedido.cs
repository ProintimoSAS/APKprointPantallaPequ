using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CapaAccesoDatos
{
    public class AccesoDatosPedido
    {
        private readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionSQL"].ConnectionString;

        public DataTable ObtenerPedidos(string nombreCliente)
        {
            
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                using (var comando = new SqlCommand("ObtenerPedidosPorCliente", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@NombreCliente", nombreCliente);
                    using (var adaptador = new SqlDataAdapter(comando))
                    {
                        var tablaPedidos = new DataTable();
                        adaptador.Fill(tablaPedidos);
                        return tablaPedidos;
                    }
                }
            }
            
        }

        public void InsertarPedido(string codigo, string nombreCliente)
        {
            try
            {
                using (var conexion = new SqlConnection(cadenaConexion))
                using (var comando = new SqlCommand("InsertarPedidoPorCliente", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@Codigo", codigo);
                    comando.Parameters.AddWithValue("@NombreCliente", nombreCliente);
                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al insertar el pedido en la base de datos");
            }            
        }
    }

}
