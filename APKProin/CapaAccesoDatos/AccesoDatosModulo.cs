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
    public class AccesoDatosModulo
    {
        SqlConnection conexionBD = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionSQL"].ConnectionString);

        public DataTable ObtenerModulos()
        {
            conexionBD.Open();
            SqlCommand comando = new SqlCommand("obtenerModulo", conexionBD);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tablaDatosModulo = new DataTable();
            adaptador.Fill(tablaDatosModulo);
            conexionBD.Close();
            return tablaDatosModulo;
        }


        public void InsertarModulo(string nombre)
        {
            conexionBD.Open();
            SqlCommand comando = new SqlCommand("InsertarModulo", conexionBD);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", nombre);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tablaInsertarDatosModulo = new DataTable();
            adaptador.Fill(tablaInsertarDatosModulo);
            conexionBD.Close();
        }

        public string ObtenerEficienciaAcumuladaPorNave(string nave)
        {
            conexionBD.Open();
            SqlCommand comando = new SqlCommand("spPromedioEficienciaAcumuladaPorNave", conexionBD);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nave", nave);
            object resultado = comando.ExecuteScalar();
            conexionBD.Close();
            return resultado.ToString();
        }

    }
}
