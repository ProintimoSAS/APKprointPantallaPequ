using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class AccesoDatosReferencia
    {
        SqlConnection conexionBD = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionSQL"].ConnectionString);

        public DataTable ObtenerReferenciaPorOrden(string codigoOrdenProduccion)
        {
            conexionBD.Open();  
            SqlCommand comando = new SqlCommand("BuscarReferenciaPorOrdenProduccion", conexionBD);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codigoOrdenProduccion", codigoOrdenProduccion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tablaDatosReferencia = new DataTable();
            conexionBD.Close();
            adaptador.Fill(tablaDatosReferencia);
            return tablaDatosReferencia;
        }

        public void InsertarReferencia(Referencia referencia, int idPedido)
        {
            conexionBD.Open();
            SqlCommand comando = new SqlCommand("insertarReferencia", conexionBD);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Codigo", referencia.Codigo);
            comando.Parameters.AddWithValue("@Color", referencia.Color);
            comando.Parameters.AddWithValue("@Descripcion", referencia.Descripcion);
            comando.Parameters.AddWithValue("@FechaCreacion", referencia.FechaCreacion);
            comando.Parameters.AddWithValue("@UnidadesTotalesAFabricar", referencia.UnidadesTotalesAFabricar);
            comando.Parameters.AddWithValue("@idPedido", idPedido);
            comando.ExecuteNonQuery(); // Ejecutar la consulta sin devolver ningún resultado
            conexionBD.Close();
        }

        public DataTable ObtenerReferenciaPorCodigo(string codigoReferencia)
        {
            conexionBD.Open();
            SqlCommand comando = new SqlCommand("BuscarReferenciaPorCodigo", conexionBD);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codigo_referencia", codigoReferencia);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tablaDatosReferencia = new DataTable();
            conexionBD.Close();
            adaptador.Fill(tablaDatosReferencia);
            return tablaDatosReferencia;
        }

    }
}
