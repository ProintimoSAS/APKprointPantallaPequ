using CapaEntidad;
using CapaNegocio;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmIngresoInfo : Form
    {       

        NegocioOrdenDeProduccion objNegocioOrdenDeProduccion = new NegocioOrdenDeProduccion();
        OrdenDeProduccion ordenDeProduccion = new OrdenDeProduccion();

        NegocioReferencia objNegocioReferencia = new NegocioReferencia();
        Referencia referencia = new Referencia();

        NegocioProduccionModulo objNegocioProduccionModulo = new NegocioProduccionModulo();
        ProduccionModulo objProduccionModulo = new ProduccionModulo();




        public frmIngresoInfo()
        {
            InitializeComponent();
            MostrarBotonGuardar();
        }

        private void btnGuardarClick(object sender, EventArgs e)
        {
            
            //Se agrega la orden de producción y la referencia a la que está asignada un modulo en específico

            int cantidadReferencias = objNegocioReferencia.ObtenerReferenciaPorCodigo(txtReferencia.Text).Rows.Count;
            //Si la referencia no existe la creo
            if (cantidadReferencias == 0)
            {
                referencia.Codigo = txtReferencia.Text;
                referencia.Color = "Sin color";
                referencia.Descripcion = txtSubCat.Text;
                referencia.FechaCreacion = Convert.ToDateTime(DateTime.Now.ToString("d"));
                referencia.UnidadesTotalesAFabricar = 1000;
                objNegocioReferencia.InsertarReferencia(referencia, 100);
            }

            string datoSam = txtSam.Text;
            CultureInfo culture = CultureInfo.CurrentCulture;
            if (culture.NumberFormat.NumberDecimalSeparator == ",")
            {
                datoSam = datoSam.Replace('.',',');
            }
            else if (culture.NumberFormat.NumberDecimalSeparator == ".")
            {
                datoSam = datoSam.Replace(',', '.');
            }


            float samFloat = float.Parse(datoSam);
            ordenDeProduccion.Codigo = txtOrdenProduccion.Text;
            ordenDeProduccion.UnidadesAFabricar = int.Parse(txtCantidad.Text);
            ordenDeProduccion.Sam = samFloat;
            ordenDeProduccion.Talla = "Sin talla";


            objNegocioOrdenDeProduccion.InsertarOrdenDeProduccion(ordenDeProduccion, txtModulo.Text, txtReferencia.Text);

            //var frmControl = new frmControlPiso();
            int unidadesFabricadas;
            float porcentajeParcial;
            float porcentajeAcumulado;
            int minutosTrabajados = CalcularMinutosTrabajados();
            float sam = float.Parse(txtSam.Text);
            int unidadesFaltantes;
            float unidadesPorhora = 0;
            float unidadesDejadasDeFabricar = 0;
            float unidadesPorHoraReal = 0;
            float porcentajeAcumuladoReal = 0;
            int totalFabricadas = 0;



            if (txtPrendasFab.Text != "")
            {
                float unidadesPorHora = (float.Parse(txtPersonas.Text) * minutosTrabajados) / samFloat;                
                double tiempoPrenda = Convert.ToDouble(samFloat / int.Parse(txtPersonas.Text));
                unidadesFabricadas = int.Parse(txtPrendasFab.Text);
                porcentajeParcial =(float.Parse(txtPrendasFab.Text) / unidadesPorHora) * 100;
                totalFabricadas = int.Parse(txtPrendasFab.Text); 

                porcentajeAcumulado = porcentajeParcial;
                unidadesFaltantes = int.Parse(txtCantidad.Text) - unidadesFabricadas;
                unidadesPorhora = (float.Parse(txtPersonas.Text) * minutosTrabajados) / sam;
                unidadesDejadasDeFabricar = unidadesPorhora - unidadesFabricadas;
                unidadesPorHoraReal = unidadesPorHora;
                porcentajeAcumuladoReal = float.Parse(txtPrendasFab.Text) / unidadesPorHoraReal;
            }
            else
            {
                unidadesFabricadas= 0;
                porcentajeAcumulado = 0;
                porcentajeParcial = 0;
                unidadesFaltantes = int.Parse(txtCantidad.Text);
            }

            if (unidadesDejadasDeFabricar < 0)
            {
                unidadesDejadasDeFabricar = 0;
            }

            objProduccionModulo.CantidadPersonas = int.Parse(txtPersonas.Text);
             objProduccionModulo.Fecha = Convert.ToDateTime(DateTime.Now.ToString("d"));
             objProduccionModulo.Hora = Convert.ToDateTime(DateTime.Now.ToString("t"));
             objProduccionModulo.TiempoPrenda = Math.Truncate(Convert.ToDouble(samFloat / int.Parse(txtPersonas.Text)));
             objProduccionModulo.UnidadesFaltantes = unidadesFaltantes;
             objProduccionModulo.UnidadesFabricadas = unidadesFabricadas;
             objProduccionModulo.NoConformes = 0;
             objProduccionModulo.PorcentajeParcial = porcentajeParcial;
             objProduccionModulo.PorcentajeAcumulado = porcentajeAcumulado;
             objProduccionModulo.UnidadesPorHora = unidadesPorhora;
             objProduccionModulo.Revision = false;
             objProduccionModulo.tiempoImproductivo = false;
             objProduccionModulo.Comentarios = txtComentario.Text;
             objProduccionModulo.TotalFabricadas = totalFabricadas;
            objProduccionModulo.UnidadesDejadasDeFabricar = unidadesDejadasDeFabricar;
            objProduccionModulo.UnidadesPorHoraReales = unidadesPorHoraReal;
            objProduccionModulo.PorcentajeAcumuladoReal = porcentajeAcumuladoReal;

            
            string codigoOrdenDeProduccion = txtOrdenProduccion.Text;

            objNegocioProduccionModulo.InsertarProduccionModulo(objProduccionModulo, ordenDeProduccion.Codigo);            


            txtModulo.Text = "";
            txtSubCat.Text = "";
            txtReferencia.Text = "";
            txtOrdenProduccion.Text = "";
            txtCantidad.Text = "";
            txtPersonas.Text = "";
            txtSam.Text = "";

            MessageBox.Show("Se agregó la orden de producción correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void activarTxtFabricadas()
        {
            int cantidadProduccionModulo = objNegocioProduccionModulo.obtenerProduccionModuloPorFecha(Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")), txtModulo.Text).Rows.Count;
            if (cantidadProduccionModulo >= 1)
            {
                txtPrendasFab.Visible = true;
                lblPrendas.Visible = true;
            }
            else 
            {
                txtPrendasFab.Visible = false;
                lblPrendas.Visible = false;
            }
        }

        private void txtModulo_TextChanged(object sender, EventArgs e)
        {
            activarTxtFabricadas();
            MostrarBotonGuardar();
        }

        public int CalcularMinutosTrabajados()
        {
            int cantidadDeElementosTablaProduccionModulo = objNegocioProduccionModulo.obtenerProduccionModuloPorFecha(Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")), txtModulo.Text).Rows.Count;


            int turno = 0;
            int minutosTrabajados = 30;
            if (txtModulo.Text == "102" || txtModulo.Text == "103")
            {
                turno = 1;
            }
            else if (txtModulo.Text == "105" || txtModulo.Text == "106" || txtModulo.Text == "110" || txtModulo.Text == "118")
            {
                turno = 2;
            }
            else if (txtModulo.Text == "200" || txtModulo.Text == "104" || txtModulo.Text == "111")
            {
                turno = 3;
            }
            else if (txtModulo.Text == "112" || txtModulo.Text == "113" || txtModulo.Text == "116")
            {
                turno = 4;
            }
            else if (txtModulo.Text == "115" || txtModulo.Text == "117" || txtModulo.Text == "120")
            {
                turno = 5;
            }
            else if (txtModulo.Text == "107" || txtModulo.Text == "126" || txtModulo.Text == "127")
            {
                turno = 6;
            }
            else if (txtModulo.Text == "108" || txtModulo.Text == "114" || txtModulo.Text == "125")
            {
                turno = 7;
            }
            else if (txtModulo.Text == "122")
            {
                turno = 8;
            }




            if (turno == 1)
            {
                if (cantidadDeElementosTablaProduccionModulo == 10)
                {
                    minutosTrabajados = 10;
                }
                else if (cantidadDeElementosTablaProduccionModulo == 16)
                {
                    minutosTrabajados = 20;
                }
                else
                {
                    minutosTrabajados = 30;
                }
            }

            else if (turno == 2)
            {
                if (cantidadDeElementosTablaProduccionModulo == 10 || cantidadDeElementosTablaProduccionModulo == 11 || cantidadDeElementosTablaProduccionModulo == 16)
                {
                    minutosTrabajados = 20;
                }
                else
                {
                    minutosTrabajados = 30;
                }
            }
            else if (turno == 3)
            {
                if (cantidadDeElementosTablaProduccionModulo == 11)
                {
                    minutosTrabajados = 10;
                }
                else if (cantidadDeElementosTablaProduccionModulo == 17)
                {
                    minutosTrabajados = 20;
                }
                else
                {
                    minutosTrabajados = 30;
                }
            }
            else if (turno == 4)
            {
                if (cantidadDeElementosTablaProduccionModulo == 11 || cantidadDeElementosTablaProduccionModulo == 12 || cantidadDeElementosTablaProduccionModulo == 4)
                {
                    minutosTrabajados = 20;
                }
                else
                {
                    minutosTrabajados = 30;
                }
            }
            else if (turno == 5)
            {
                if (cantidadDeElementosTablaProduccionModulo == 12)
                {
                    minutosTrabajados = 10;
                }
                else if (cantidadDeElementosTablaProduccionModulo == 5)
                {
                    minutosTrabajados = 20;
                }
                else
                {
                    minutosTrabajados = 30;
                }
            }
            else if (turno == 6)
            {
                if (cantidadDeElementosTablaProduccionModulo == 12 || cantidadDeElementosTablaProduccionModulo == 13 || cantidadDeElementosTablaProduccionModulo == 5)
                {
                    minutosTrabajados = 20;
                }
                else
                {
                    minutosTrabajados = 30;
                }
            }
            else if (turno == 7)
            {
                if (cantidadDeElementosTablaProduccionModulo == 13)
                {
                    minutosTrabajados = 10;
                }
                else if (cantidadDeElementosTablaProduccionModulo == 5)
                {
                    minutosTrabajados = 20;
                }
                else
                {
                    minutosTrabajados = 30;
                }
            }
            else if (turno == 8)
            {
                if (cantidadDeElementosTablaProduccionModulo == 13)
                {
                    minutosTrabajados = 10;
                }
                else if (cantidadDeElementosTablaProduccionModulo == 6)
                {
                    minutosTrabajados = 20;
                }
                else
                {
                    minutosTrabajados = 30;
                }
            }

            if (cantidadDeElementosTablaProduccionModulo == 1)
            {
                minutosTrabajados = 20;
            }

            return minutosTrabajados;
        }

        public DataTable datosTablaOrdenDeProduccion()
        {
            return objNegocioOrdenDeProduccion.obtenerOrdenesDeProduccion(txtModulo.Text);
        }

        public DataTable datosTablaReferencia()
        {
            return objNegocioReferencia.obtenerReferencia(objNegocioOrdenDeProduccion.obtenerCodigoOrden(txtModulo.Text));
        }

        public DataTable datosTablaProduccionModulo()
        {
            return objNegocioProduccionModulo.obtenerProduccionModulo(objNegocioOrdenDeProduccion.obtenerCodigoOrden(txtModulo.Text));
        }

        public DataTable datosTablaProduccionModuloPorFecha()
        {
            return objNegocioProduccionModulo.obtenerProduccionModuloPorFecha(Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")), txtModulo.Text);
        }

        public T encontrarUltimaFilaColumna<T>(DataTable tabla, string columna)
        {

            int rowCount = tabla.Rows.Count;

            if (rowCount > 0)
            {
                // Obtener la última fila del DataTable
                DataRow lastRow = tabla.Rows[rowCount - 1];

                // Obtener el valor de la columna en la última fila
                object lastValue = lastRow[columna];

                if (lastValue != DBNull.Value)
                {
                    return (T)Convert.ChangeType(lastValue, typeof(T));
                }
                else
                {
                    return (T)(object)(-9999);
                }
            }
            else
            {
                Console.WriteLine(columna);
                Console.WriteLine(columna);
                Console.WriteLine(columna);
                Console.WriteLine(columna);
                return (T)(object)"";
            }
        }

        private void txtSam_TextChanged(object sender, EventArgs e)
        {
            MostrarBotonGuardar();
        }

        private void MostrarBotonGuardar()
        {
            if (txtReferencia.Text != "" && txtModulo.Text != "" && txtSubCat.Text != "" && txtOrdenProduccion.Text != "" && txtCantidad.Text != "" && txtPersonas.Text != "" && txtSam.Text != "")
            {
                btnGuardar.Enabled = true;
            }
            else
            {
                btnGuardar.Enabled = false;
            }
        }

        private void txtSubCat_TextChanged(object sender, EventArgs e)
        {
            MostrarBotonGuardar();
        }

        private void txtOrdenProduccion_TextChanged(object sender, EventArgs e)
        {
            MostrarBotonGuardar();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            MostrarBotonGuardar();
        }

        private void txtReferencia_TextChanged(object sender, EventArgs e)
        {
            MostrarBotonGuardar();
        }

        private void txtPersonas_TextChanged(object sender, EventArgs e)
        {
            MostrarBotonGuardar();
        }
    }
}
