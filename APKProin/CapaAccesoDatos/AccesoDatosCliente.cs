using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class AccesoDatosCliente
    {
        SqlConnection conexionBD = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionSQL"].ConnectionString);

        public DataTable ObtenerClientes()
        {
            conexionBD.Open();
            SqlCommand comando = new SqlCommand("ObtenerClientes", conexionBD);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tablaDatosClientes = new DataTable();
            adaptador.Fill(tablaDatosClientes);
            conexionBD.Close();
            return tablaDatosClientes;
        }


    }
}
