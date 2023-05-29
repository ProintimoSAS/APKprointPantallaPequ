using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Drawing;


namespace CapaAccesoDatos
{
    public class AccesoDatosOrdenDeProduccion
    {
        SqlConnection conexionBD = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionSQL"].ConnectionString);

        public DataTable ObtenerOrdenesDeProduccion()
        {
            conexionBD.Open();
            SqlCommand comando = new SqlCommand("obtenerOrdenesDeProduccion", conexionBD);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tablaDatosModulo = new DataTable();
            adaptador.Fill(tablaDatosModulo);
            conexionBD.Close();
            return tablaDatosModulo;
        }
 
        public DataTable ObtenerOrdenPorModulo(string nombreModulo)
        {
            conexionBD.Open();
            SqlCommand comando = new SqlCommand("ObtenerOrdenesProduccionPorNombreModulo", conexionBD);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombreModulo", nombreModulo);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tablaDatosOrdenDeProduccion = new DataTable();
            conexionBD.Close();
            adaptador.Fill(tablaDatosOrdenDeProduccion);
            return tablaDatosOrdenDeProduccion;
        }

        public string ObtenerCodigoOrdenPorModulo(string nombreModulo)
        {
            conexionBD.Open();
            SqlCommand comando = new SqlCommand("spBuscarCodigoOrdenProduccion", conexionBD);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombreModulo", nombreModulo);

            object resultado = comando.ExecuteScalar();
            conexionBD.Close();
            return resultado != null ? resultado.ToString() : null;
        }

        public void InsertarOrdenDeProduccion(OrdenDeProduccion ordenDeProduccion, string nombreModulo, string codigoReferencia)
        {
            conexionBD.Open();
            SqlCommand comando = new SqlCommand("insertarOrdenDeProduccion", conexionBD);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Codigo", ordenDeProduccion.Codigo);
            comando.Parameters.AddWithValue("@UnidadesAFabricar", ordenDeProduccion.UnidadesAFabricar);
            comando.Parameters.AddWithValue("@Sam", ordenDeProduccion.Sam);
            comando.Parameters.AddWithValue("@Talla", ordenDeProduccion.Talla);
            comando.Parameters.AddWithValue("@nombreModulo", nombreModulo);
            comando.Parameters.AddWithValue("@codigoReferencia", codigoReferencia);            
            comando.ExecuteNonQuery(); // Ejecutar la consulta sin devolver ningún resultado
            conexionBD.Close();
        }
    }
}
