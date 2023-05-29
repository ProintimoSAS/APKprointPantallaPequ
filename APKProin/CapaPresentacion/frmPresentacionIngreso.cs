using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class frmPresentacionIngreso : Form
    {
        CapaEntidad.EntidadIngreso objEntidad = new CapaEntidad.EntidadIngreso();
        CapaNegocio.NegocioIngreso objNegocio = new CapaNegocio.NegocioIngreso();

        public frmPresentacionIngreso()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            {
                try
                {
                    objEntidad.datoUsuarioEntidad = txtUsuario.Text;
                    objEntidad.datoClaveEntidad = txtContraseña.Text;

                    DataTable DatosPresentacion = new DataTable();
                    DatosPresentacion = objNegocio.DatosNegocio(objEntidad);

                    if (DatosPresentacion.Rows.Count > 0)
                    {
                        MessageBox.Show("bienvenido a la aplicacion");
                        this.Hide();
                        frmPresentacionInicioPrincipal frmProductos = new frmPresentacionInicioPrincipal();
                        frmProductos.Show();

                    }
                    else
                    {
                        MessageBox.Show("falla de conexion");
                        txtUsuario.Clear();
                        txtContraseña.Clear();
                        txtUsuario.Focus();

                    }
                }
                catch (SqlException err)
                {
                    if (err.Number == 1042)
                        MessageBox.Show(" Error en la canexion a la base de datos porfavor verificar.....");
                }
            }
         }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PresentacionIngreso_Load(object sender, EventArgs e)
        {

        }
    }
}
