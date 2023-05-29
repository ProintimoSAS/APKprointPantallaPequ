using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CapaAccesoDatos
{
    public class AccesoDatosIngreso
    {
        SqlConnection conexionBD = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionSQL"].ConnectionString);
        public DataTable ValidarUsuario(CapaEntidad.EntidadIngreso objEntidad)
        {
            conexionBD.Open();
            SqlCommand comando = new SqlCommand("SP_Ingresologin",conexionBD);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("usuario", objEntidad.datoUsuarioEntidad);
            comando.Parameters.AddWithValue("clave", objEntidad.datoClaveEntidad);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tablaDatosUsuario = new DataTable();
            adaptador.Fill(tablaDatosUsuario);
            conexionBD.Close();
            return tablaDatosUsuario;


        }
    }
}
