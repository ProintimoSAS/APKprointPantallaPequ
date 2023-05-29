using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaAccesoDatos
{
    public class AccesoDatosProduccionModulo
    {
        SqlConnection conexionBD = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionSQL"].ConnectionString);

        public DataTable ObtenerProduccionModulo(string codigoOrdenProduccion)
        {
            conexionBD.Open();
            SqlCommand comando = new SqlCommand("ObtenerProduccionModuloPorCodigoOrdenDeProduccion", conexionBD);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codigoOrdenDeProduccion", codigoOrdenProduccion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tablaDatosProduccionModulo = new DataTable();
            conexionBD.Close();
            adaptador.Fill(tablaDatosProduccionModulo);
            return tablaDatosProduccionModulo;
        }

        public DataTable ObtenerProduccionModuloPorFecha(DateTime fecha, string modulo)
        {
            conexionBD.Open();
            SqlCommand comando = new SqlCommand("ObtenerProduccionModuloPorFechaYModulo", conexionBD);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@FechaProduccion", fecha);
            comando.Parameters.AddWithValue("@NombreModulo", modulo);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tablaDatosProduccionModulo = new DataTable();
            conexionBD.Close();
            adaptador.Fill(tablaDatosProduccionModulo);
            return tablaDatosProduccionModulo;
        }

        public DataTable ObtenerProduccionModuloPorFechaYOrden(DateTime fecha, string codigoOrden)
        {
            conexionBD.Open();
            SqlCommand comando = new SqlCommand("obtenerProduccionModuloPorFechaYOrden", conexionBD);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@codigoOrdenDeProduccion", codigoOrden);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tablaDatosProduccionModulo = new DataTable();
            conexionBD.Close();
            adaptador.Fill(tablaDatosProduccionModulo);
            return tablaDatosProduccionModulo;
        }

        public void InsertarProduccionModulo(ProduccionModulo produccionModulo, string codigoOrdenDeProduccion)
        {
            conexionBD.Open();
            SqlCommand comando = new SqlCommand("ingresarProduccionModulo", conexionBD);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@CantidadPersonas", produccionModulo.CantidadPersonas);
            comando.Parameters.AddWithValue("@Fecha", produccionModulo.Fecha);
            comando.Parameters.AddWithValue("@Hora", produccionModulo.Hora);
            comando.Parameters.AddWithValue("@UnidadesFaltantes", produccionModulo.UnidadesFaltantes);
            comando.Parameters.AddWithValue("@UnidadesFabricadas", produccionModulo.UnidadesFabricadas);
            comando.Parameters.AddWithValue("@TiempoPrenda", produccionModulo.TiempoPrenda);
            comando.Parameters.AddWithValue("@NoConformes", produccionModulo.NoConformes);
            comando.Parameters.AddWithValue("@PorcentajeParcial", produccionModulo.PorcentajeParcial);
            comando.Parameters.AddWithValue("@PorcentajeAcumulado", produccionModulo.PorcentajeAcumulado);
            comando.Parameters.AddWithValue("@UnidadesPorHora", produccionModulo.UnidadesPorHora);
            comando.Parameters.AddWithValue("@Revision", produccionModulo.Revision);
            comando.Parameters.AddWithValue("@tiempoImproductivo", produccionModulo.tiempoImproductivo);
            comando.Parameters.AddWithValue("@TotalFabricadas", produccionModulo.TotalFabricadas);
            comando.Parameters.AddWithValue("@Comentarios", produccionModulo.Comentarios);
            comando.Parameters.AddWithValue("@UnidadesDejadasDeFabricar", produccionModulo.UnidadesDejadasDeFabricar);
            comando.Parameters.AddWithValue("@UnidadesPorHoraReales", produccionModulo.UnidadesPorHoraReales);
            comando.Parameters.AddWithValue("@PorcentajeAcumuladoReal", produccionModulo.PorcentajeAcumuladoReal);
            comando.Parameters.AddWithValue("@codigoOrdenDeProduccion", codigoOrdenDeProduccion);
            comando.ExecuteNonQuery(); // Ejecutar la consulta sin devolver ningún resultado
            conexionBD.Close();
        }


        public void EliminarUltimoDatoProduccionModulo(string codigoOrdenProduccion)
        {
            conexionBD.Open();
            SqlCommand comando = new SqlCommand("eliminarUltimoDatoProduccionModuloPorCodigoOrdenDeProduccion", conexionBD);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codigoOrdenDeProduccion", codigoOrdenProduccion);
            comando.ExecuteNonQuery();
            conexionBD.Close();
        }

        public int ObtenerSumaEficienciaAcumuladaPorNave(string nave, DateTime fecha)
        {
            int sumaEficiencia = 0;
            conexionBD.Open();
            SqlCommand comando = new SqlCommand("spSumaEficienciaAcumuladaUltimoDatoPorNave", conexionBD);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nave", nave);
            comando.Parameters.AddWithValue("@fechaEspecifica", fecha);

            object resultado = comando.ExecuteScalar();

            if (resultado != null && resultado != DBNull.Value)
            {
                sumaEficiencia = Convert.ToInt32(resultado);
            }
            conexionBD.Close();
            return sumaEficiencia;
        }

        public float ObtenerTotalUnidadesEsperadasPorNave(string nave, DateTime fecha)
        {
            float unidadesEsperadas = 0;
            conexionBD.Open();
            SqlCommand comando = new SqlCommand("ObtenerSumaUnidadesPorHoraPorNaveYFecha", conexionBD);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombreNave", nave);
            comando.Parameters.AddWithValue("@fecha", fecha);

            object resultado = comando.ExecuteScalar();

            if (resultado != null && resultado != DBNull.Value)
            {
                unidadesEsperadas = Convert.ToInt32(resultado);
            }
            conexionBD.Close();
            return unidadesEsperadas;
        }

        public int ObtenerTotalUnidadesFabricadasPorNave(string nave, DateTime fecha)
        {
            int unidadesFabricadas = 0;
            conexionBD.Open();
            SqlCommand comando = new SqlCommand("ObtenerSumaUnidadesFabricadasPorNaveYFecha", conexionBD);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombreNave", nave);
            comando.Parameters.AddWithValue("@fecha", fecha);

            object resultado = comando.ExecuteScalar();

            if (resultado != null && resultado != DBNull.Value)
            {
                unidadesFabricadas = Convert.ToInt32(resultado);
            }

            conexionBD.Close();
            return unidadesFabricadas;
        }

        public int ObtenerTotalUnidadesEsperadasRealesPorNave(string nave, DateTime fecha)
        {
            int unidadesPorHoraReales = 0;
            conexionBD.Open();
            SqlCommand comando = new SqlCommand("ObtenerSumaUnidadesPorHoraRealPorNaveYFecha", conexionBD);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombreNave", nave);
            comando.Parameters.AddWithValue("@fecha", fecha);

            object resultado = comando.ExecuteScalar();

            if (resultado != null && resultado != DBNull.Value)
            {
                unidadesPorHoraReales = Convert.ToInt32(resultado);
            }

            conexionBD.Close();
            return unidadesPorHoraReales;
        }


        public DataTable ObtenerComentFabriAcumRealPorFecha(DateTime fecha, string modulo)
        {
            conexionBD.Open();
            SqlCommand comando = new SqlCommand("ObtenerFabricadasComentariosPorcentajeAcumRealPorFechaYModulo", conexionBD);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@FechaProduccion", fecha);
            comando.Parameters.AddWithValue("@NombreModulo", modulo);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tablaDatosProduccionModulo = new DataTable();
            conexionBD.Close();
            adaptador.Fill(tablaDatosProduccionModulo);
            return tablaDatosProduccionModulo;
        }
    }
}
