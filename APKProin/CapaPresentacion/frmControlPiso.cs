using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
using static C1.Util.Win.Win32;

namespace CapaPresentacion
{
    public partial class frmControlPiso : Form
    {
        public static string modulo = frmAccesosControlPiso.numeroModulo;

        NegocioReferencia objNegocioReferencia = new NegocioReferencia();//instancia para usar los métodos de negocio referencia

        NegocioOrdenDeProduccion objNegocioOrdenProduccion = new NegocioOrdenDeProduccion();//instancia para usar los métodos de negocio orden de producción

        NegocioProduccionModulo objNegocioProduccionModulo = new NegocioProduccionModulo();//instancia para usar métodos de negocio Producción modulo
        ProduccionModulo objProduccionModulo = new ProduccionModulo();


        public frmControlPiso()
        {
            InitializeComponent();
        }

        //Se cambio el formato de la fecha y de la hora
        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("t");
            lblFecha.Text = DateTime.Now.ToString("d");            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            CargarDatosEnFormulario();
        }

        private void panelControlpiso_Paint(object sender, PaintEventArgs e)
        {
            //condicion para cargar lblmodulo con lo que trae la variable compartida
            lblModulo.Text = frmAccesosControlPiso.numeroModulo;
            CargarDatosEnFormulario();
            txtUnidadesFabricadas.Focus();
        }

        //Método que se ejecuta cada que se pulsa el botón guardar
        private void btnGaurdar_Click(object sender, EventArgs e)
        {

            DataTable tablaProduccionModulo = datosTablaProduccionModulo();
            DataTable tablaOrdenDeProduccion = datosTablaOrdenDeProduccion();

            double sumaUnidadesFabricadas = totalUnidadesFabricadas();
            double fabricadas = Convert.ToDouble(txtUnidadesFabricadas.Text);
            double porcentajeAcumuladoReal;

            int minutosTrabajados;

            if (txtMinutosTrabajados.Text != "")
            {
                minutosTrabajados = int.Parse(txtMinutosTrabajados.Text);
            }
            else
            {
                minutosTrabajados = CalcularMinutosTrabajados();
            }

            int cantidadDeElementosTablaProduccionModulo = tablaProduccionModulo.Rows.Count;
            int unidadesFaltantes = encontrarUltimaFilaColumna<int>(tablaProduccionModulo, "UnidadesFaltantes") - Convert.ToInt32(txtUnidadesFabricadas.Text);
            float sam = encontrarUltimaFilaColumna<float>(tablaOrdenDeProduccion, "Sam");
            int cantidadPersonas;

            if (txtActualizarNumeroPersonas.Text != "")
            {
                cantidadPersonas = int.Parse(txtActualizarNumeroPersonas.Text);
            }
            else
            {
                cantidadPersonas = encontrarUltimaFilaColumna<int>(tablaProduccionModulo, "CantidadPersonas");
            }


            double unidadesPorHora = Convert.ToDouble((cantidadPersonas * minutosTrabajados) / sam);
            string codigoOrdenDeProduccion = objNegocioOrdenProduccion.obtenerCodigoOrden(lblModulo.Text);
            double tiempoPrenda = Convert.ToDouble(sam / cantidadPersonas);
            double porcentajeParcial = fabricadas / unidadesPorHora * 100;
            double porcentajeAcumulado;
            double dejadasDeFabricar = unidadesPorHora - fabricadas;

            if (dejadasDeFabricar < 0)
            {
                dejadasDeFabricar = 0;
            }
            int totalFabricadas = encontrarUltimaFilaColumna<int>(tablaProduccionModulo, "TotalFabricadas");
            if (totalFabricadas == -9999)
            {
                totalFabricadas = 0;
            }
            else
            {
                totalFabricadas = encontrarUltimaFilaColumna<int>(tablaProduccionModulo, "TotalFabricadas");
            }

            totalFabricadas += int.Parse(txtUnidadesFabricadas.Text);
            double unidadesPorHoraReales = unidadesPorHora;

            if (cantidadDeElementosTablaProduccionModulo <= 1)
            {
                porcentajeAcumulado = porcentajeParcial;
                porcentajeAcumuladoReal = porcentajeParcial;
            }
            else
            {
                porcentajeAcumulado = (sumaUnidadesFabricadas + fabricadas) / (totalUnidadesEsperadas() + unidadesPorHora) * 100;
                porcentajeAcumuladoReal = (sumaUnidadesFabricadas + fabricadas) / (totalUnidadesEsperadasReales() + unidadesPorHoraReales) * 100;
            }

            

            Guardar(cantidadPersonas, Convert.ToDateTime(lblFecha.Text), Convert.ToDateTime(lblHora.Text), unidadesFaltantes, int.Parse(txtUnidadesFabricadas.Text), tiempoPrenda, porcentajeParcial, porcentajeAcumulado, unidadesPorHora, false, codigoOrdenDeProduccion , txtComentario.Text, totalFabricadas, unidadesPorHoraReales, dejadasDeFabricar, porcentajeAcumuladoReal);
            MessageBox.Show("el dato fue insertado existosamente ", "Insertar prendas fabricadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Al presionar el botón guardar se limpia el textbox donde se ingresó las unidades fabricadas
            txtUnidadesFabricadas.Text = "";
            txtComentario.Text = "";
            txtActualizarNumeroPersonas.Text = "";
            txtMinutosTrabajados.Text = "";

                   

            panelActualizarInfo.Visible = false;
            CargarDatosEnFormulario();
        }

        public void Guardar(int cantidadPersonas, DateTime Fecha, DateTime Hora, int unidadesFaltantes, int unidadesFabricadas, double tiempoPrenda, double porcentajeParcial, double porcentajeAcumulado, double unidadesPorHora, bool tiempoImproductivo,string codigoOrdenDeProduccion, string comentarios,int totalFabricadas,  double unidadesPorHoraReales,double unidadesDejadasDeFabricar, double porcentajeAcumuladoReal)
        {
            objProduccionModulo.CantidadPersonas = cantidadPersonas;
            objProduccionModulo.Fecha = Fecha;
            objProduccionModulo.Hora= Hora;
            objProduccionModulo.UnidadesFaltantes = unidadesFaltantes;
            objProduccionModulo.UnidadesFabricadas = unidadesFabricadas;
            objProduccionModulo.TiempoPrenda= tiempoPrenda;
            objProduccionModulo.NoConformes= 0;
            objProduccionModulo.PorcentajeParcial = porcentajeParcial;
            objProduccionModulo.PorcentajeAcumulado = porcentajeAcumulado;
            objProduccionModulo.UnidadesPorHora = unidadesPorHora;
            objProduccionModulo.Revision = false;
            objProduccionModulo.tiempoImproductivo = tiempoImproductivo;
            objProduccionModulo.Comentarios = comentarios;
            objProduccionModulo.TotalFabricadas = totalFabricadas;
            objProduccionModulo.UnidadesPorHoraReales = unidadesPorHoraReales;
            objProduccionModulo.UnidadesDejadasDeFabricar = unidadesDejadasDeFabricar;
            objProduccionModulo.PorcentajeAcumuladoReal = porcentajeAcumuladoReal;

            objNegocioProduccionModulo.InsertarProduccionModulo(objProduccionModulo, codigoOrdenDeProduccion);            
        }

        private void btnTiempoImproductivo_Click(object sender, EventArgs e)
        {
            DataTable tablaProduccionModulo = datosTablaProduccionModulo();
            DataTable tablaOrdenDeProduccion = datosTablaOrdenDeProduccion();
            double sumaUnidadesFabricadas = totalUnidadesFabricadas();


            float sam = encontrarUltimaFilaColumna<float>(datosTablaOrdenDeProduccion(), "Sam");
            int minutosTrabajados = CalcularMinutosTrabajados();
            int cantidadPersonas = encontrarUltimaFilaColumna<int>(tablaProduccionModulo, "CantidadPersonas");
            int unidadesFaltantes = encontrarUltimaFilaColumna<int>(tablaProduccionModulo, "UnidadesFaltantes");
            double tiempoPrenda = encontrarUltimaFilaColumna<double>(tablaProduccionModulo, "TiempoPrenda");
            
            double porcentajeAcumuladoReal = encontrarUltimaFilaColumna<double>(tablaProduccionModulo, "PorcentajeAcumuladoReal");
            double unidadesPorHora = Convert.ToDouble((cantidadPersonas * minutosTrabajados) / sam);
            string codigoOrdenDeProduccion = encontrarUltimaFilaColumna<string>(tablaOrdenDeProduccion, "Codigo");
            int totalFabricadas = encontrarUltimaFilaColumna<int>(tablaProduccionModulo, "TotalFabricadas");
            double unidadesDejadasDeFabricar = unidadesPorHora;
            double unidadesPorHoraReal = unidadesPorHora;
            double porcentajeAcumulado = sumaUnidadesFabricadas / (totalUnidadesEsperadasReales() + unidadesPorHoraReal) * 100;


            Guardar(cantidadPersonas, Convert.ToDateTime(lblFecha.Text), Convert.ToDateTime(lblHora.Text), unidadesFaltantes, 0, tiempoPrenda, 0, porcentajeAcumulado, 0, true,codigoOrdenDeProduccion, txtComentario.Text, totalFabricadas, unidadesPorHoraReal, unidadesDejadasDeFabricar, porcentajeAcumuladoReal);
            MessageBox.Show("ATENCIÓN \n Usted ingresará un tiempo improductivo", "Tiempo improductivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtComentario.Text = "";
            CargarDatosEnFormulario();
        }

        //Función para mostrar los datos en el formulario dependiendo del módulo deseado
        public void CargarDatosEnFormulario()
        {
            // Obtener datos de las tablas necesarias
            DataTable tablaProduccionModulo = datosTablaProduccionModulo();
            DataTable tablaProduccionModuloPorFecha = datosTablaProduccionModuloPorFecha();
            DataTable tablaOrdenDeProduccion = datosTablaOrdenDeProduccion();
            DataTable tablaReferencia = datosTablaReferencia();

            // Verificar si hay más de un registro en la tabla de producción del módulo por fecha
            bool hayMasDeUnRegistro = tablaProduccionModuloPorFecha.Rows.Count > 1;

            // Mostrar o no el botón de eliminar según corresponda
            btnEliminar.Visible = hayMasDeUnRegistro;

            // Insertar el primer dato del día si no hay ningún registro en la tabla de producción del módulo por fecha
            if (tablaProduccionModuloPorFecha.Rows.Count == 0)
            {
                insertarPrimerDatoDelDia();
            }

            // Obtener los valores necesarios de las tablas
            int minutosTrabajados = CalcularMinutosTrabajados();
            int unidadesFaltantes = encontrarUltimaFilaColumna<int>(tablaProduccionModulo, "UnidadesFaltantes");
            float sam = encontrarUltimaFilaColumna<float>(tablaOrdenDeProduccion, "Sam");
            int cantidadPersonas = encontrarUltimaFilaColumna<int>(tablaProduccionModulo, "CantidadPersonas");
            double unidadesPorHora = encontrarUltimaFilaColumna<float>(tablaProduccionModulo, "UnidadesPorHora");
            double porcentajeAcumulado = encontrarUltimaFilaColumna<double>(tablaProduccionModulo, "PorcentajeAcumulado") / 100f;
            double tiempoParaTerminarOrden = unidadesFaltantes / (unidadesPorHora * porcentajeAcumulado) / 2f;
            string mensaje = tiempoParaTerminarOrden < 1 ? "Se espera terminar la orden de producción en menos de una hora" : $"Se espera terminar la orden de producción en {quitarDecimales(tiempoParaTerminarOrden)} Horas";

            // Asignar valores a los controles del formulario
            lblOrdenProduccion.Text = encontrarUltimaFilaColumna<string>(tablaOrdenDeProduccion, "Codigo");
            lblreferencia.Text = encontrarUltimaFilaColumna<string>(tablaReferencia, "Codigo");
            lblTotalUnidades.Text = encontrarUltimaFilaColumna<int>(tablaOrdenDeProduccion, "UnidadesAFabricar").ToString();
            lblPersonas.Text = cantidadPersonas.ToString();
            lblUnidadesXhora.Text = Math.Round(cantidadPersonas * minutosTrabajados / sam).ToString();
            labelNumeroUnidadesFaltantes.Text = unidadesFaltantes.ToString();
            lblSam.Text = sam.ToString();
            lblPrediccion.Text = mensaje;
            lblFabricadas.Text = totalUnidadesFabricadas().ToString();

            //label8.Text = Convert.ToInt32(encontrarUltimaFilaColumna<float>(tablaProduccionModulo, "PorcentajeAcumuladoReal")).ToString();

            DataTable tablaPorcentajesEnteros = tablaProduccionModuloPorFecha;

            ConvertirColumnaAEnteros(tablaPorcentajesEnteros, "PorcentajeAcumulado");
            ConvertirColumnaAEnteros(tablaPorcentajesEnteros, "PorcentajeParcial");

            // Configurar la apariencia del DataGridView
            dgvDatos.DataSource = tablaPorcentajesEnteros;
            dgvDatos.Columns[9].Visible = false;
            dgvDatos.Columns["id"].Visible = false;
            dgvDatos.Columns["Fecha"].Visible = false;
            dgvDatos.Columns["TiempoPrenda"].Visible = false;
            dgvDatos.Columns["NoConformes"].Visible = false;
            dgvDatos.Columns["UnidadesPorHora"].Visible = false;
            dgvDatos.Columns["PorcentajeAcumulado"].Visible = true;
            dgvDatos.Columns["idOrdenDeProduccion"].Visible = false;
            dgvDatos.Columns["Revision"].Visible = false;
            dgvDatos.Columns["TiempoImproductivo"].Visible = false;
            dgvDatos.Columns["ToTalFabricadas"].Visible = false;
            dgvDatos.Columns["UnidadesDejadasDeFabricar"].Visible = false;
            dgvDatos.Columns["UnidadesPorHoraReales"].Visible = false;
            dgvDatos.Columns["PorcentajeAcumuladoReal"].Visible = false;

            // MUESTRA EL TITULO DE LA COLUMNA EN LA GRILLA/
            dgvDatos.Columns["UnidadesFaltantes"].HeaderText = "Pendientes";
            dgvDatos.Columns["UnidadesFabricadas"].HeaderText = "Fabricadas";
            dgvDatos.Columns["PorcentajeParcial"].HeaderText = "%Parcial";
            dgvDatos.Columns["PorcentajeAcumulado"].HeaderText = "%Acumulado";
            dgvDatos.Columns["CantidadPersonas"].HeaderText = "Personas";
            dgvDatos.Columns["Comentarios"].HeaderText = "Novedad";
            dgvDatos.Columns["Hora"].HeaderText = "Ingreso";


            graficoPorcentajeTotalLogrado();
            graficoPorcentajeAcumulado();
        }


        private void txtUnidadesFabricadas_TextChanged(object sender, EventArgs e)
        { /* funcion para habilitar el boton guardar */
            if (string.IsNullOrWhiteSpace(txtUnidadesFabricadas.Text))
            {
                btnGaurdar.Visible = false;
                btnGaurdar.Enabled = false;
            }
            else
            {
                btnGaurdar.Visible = true;
                btnGaurdar.Enabled = true;
            }
        }

        private void txtUnidadesFabricadas_KeyPress(object sender, KeyPressEventArgs e)
        { /*funcion para solo aceptar numeros en la caja de texto */
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            graficoPorcentajeAcumulado();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            graficoPorcentajeTotalLogrado();
        }

        public void graficoPorcentajeTotalLogrado()
        {
            double unidadesAFabricar = encontrarUltimaFilaColumna<int>(datosTablaOrdenDeProduccion(), "UnidadesAFabricar");
            double unidadesFaltantes = encontrarUltimaFilaColumna<int>(datosTablaProduccionModulo(), "UnidadesFaltantes");
            int variabled = (int)quitarDecimales(((unidadesAFabricar  - unidadesFaltantes) / unidadesAFabricar) * 100);
            //int variabled = 1;
            //Si el porcentaje sobre pasa el 100% se define el límite en lo que estpé%
            if (variabled >= 99)
            {
                ProgressBar1.Maximum = variabled;
            }
            if (variabled < 99)
            {
                ProgressBar1.Maximum = 100;
            }

            ProgressBar1.Value = variabled;
            ProgressBar1.Text = ProgressBar1.Value.ToString() + "%";
            if (ProgressBar1.Value == variabled)
            {
                timer1.Enabled = false;
            }
        }

        public void graficoPorcentajeAcumulado()
        {
            int variabled;

            variabled = encontrarUltimaFilaColumna<int>(datosTablaProduccionModulo(), "PorcentajeAcumulado");

            if (variabled >= 99)
            {
                ProgressBar2.Maximum = variabled;
            }
            if (variabled < 99)
            {
                ProgressBar2.Maximum = 100;
            }

            ProgressBar2.Value = variabled;
            ProgressBar2.Text = ProgressBar2.Value.ToString() + "%";

            if (ProgressBar2.Value >= 0 && ProgressBar2.Value <= 59)
            {
                ProgressBar2.ProgressColor = Color.Red;
            }
            else if (ProgressBar2.Value >= 60 && ProgressBar2.Value <= 79)
            {
                ProgressBar2.ProgressColor = Color.Yellow;
            }
            else
            {
                ProgressBar2.ProgressColor = Color.Green;
            }


            if (ProgressBar2.Value == variabled)
            {
                timer2.Enabled = false;
            }
        }

        public T encontrarUltimaFilaColumna<T>(DataTable tabla, string columna)
        {
            if (tabla == null || columna == null)
            {
                return default(T); // Retorna el valor predeterminado de T si tabla o columna son nulos
            }

            if (!tabla.Columns.Contains(columna))
            {
                return default(T); // Retorna el valor predeterminado de T si la columna no existe
            }

            int rowCount = tabla.Rows.Count;

            if (rowCount > 0)
            {
                DataRow lastRow = tabla.Rows[rowCount - 1];

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
                return (T)(object)"";
            }
        }


        public double quitarDecimales(double numeroAQuitarDecimales)
        {
            return Math.Truncate(numeroAQuitarDecimales);
        }


        //Función que calcula las unidades fabricadas
        public double totalUnidadesFabricadas()
        {
            double totalFabricadas = 0;
            for (int i = 0; i < datosTablaProduccionModuloPorFecha().Rows.Count; i++)
            {
                totalFabricadas += Convert.ToDouble(datosTablaProduccionModuloPorFecha().Rows[i]["UnidadesFabricadas"]);
            }
            return totalFabricadas;
        }

        public double totalUnidadesEsperadas()
        {
            double totalEsperadas = 0;
            for (int i = 0; i < datosTablaProduccionModuloPorFecha().Rows.Count; i++)
            {
                totalEsperadas += Convert.ToDouble(datosTablaProduccionModuloPorFecha().Rows[i]["UnidadesPorHora"]);
            }
            return totalEsperadas;
        }

        public double totalUnidadesEsperadasReales()
        {
            double totalEsperadas = 0;
            for (int i = 0; i < datosTablaProduccionModuloPorFecha().Rows.Count; i++)
            {
                totalEsperadas += Convert.ToDouble(datosTablaProduccionModuloPorFecha().Rows[i]["UnidadesPorHoraReales"]);
            }
            return totalEsperadas;
        }

        public double totalDejadasDeFabricar()
        {
            double totalDejadasDeFavbric = 0;
            for (int i = 0; i < datosTablaProduccionModuloPorFecha().Rows.Count; i++)
            {
                totalDejadasDeFavbric += Convert.ToDouble(datosTablaProduccionModuloPorFecha().Rows[i]["UnidadesDejadasDeFabricar"]);
            }
            return totalDejadasDeFavbric;
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar el último registro?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //Comprobar la opción seleccionada por el usuario
            if (result == DialogResult.OK)
            {
                //El usuario ha seleccionado "Aceptar", realizar la acción
                objNegocioProduccionModulo.EliminarProduccionModulo(objNegocioOrdenProduccion.obtenerCodigoOrden(lblModulo.Text));
            }
            else
            {
                //El usuario ha seleccionado "Cancelar", no hacer nada
                return;
            }
            CargarDatosEnFormulario();
        }


        public DataTable datosTablaOrdenDeProduccion()
        {
            return objNegocioOrdenProduccion.obtenerOrdenesDeProduccion(lblModulo.Text);
        }

        public DataTable datosTablaReferencia()
        {
            return objNegocioReferencia.obtenerReferencia(objNegocioOrdenProduccion.obtenerCodigoOrden(lblModulo.Text));
        }

        public DataTable datosTablaProduccionModulo()
        {
            return objNegocioProduccionModulo.obtenerProduccionModulo(objNegocioOrdenProduccion.obtenerCodigoOrden(lblModulo.Text));
        }

        public DataTable datosTablaProduccionModuloPorFecha()
        {
            return objNegocioProduccionModulo.obtenerProduccionModuloPorFecha(dtpFechaModuloBuscar.Value, lblModulo.Text);
        }

        public int CalcularMinutosTrabajados()
        {
            int cantidadDeElementosTablaProduccionModulo = datosTablaProduccionModuloPorFecha().Rows.Count;


            int turno = 0;
            int minutosTrabajados = 30;
            


            if (lblModulo.Text == "102" || lblModulo.Text == "103")
            {
                turno = 1;
            }
            else if (lblModulo.Text == "105" || lblModulo.Text == "106" || lblModulo.Text == "110" || lblModulo.Text == "118")
            {
                turno = 2;
            }
            else if (lblModulo.Text == "200" || lblModulo.Text == "104" || lblModulo.Text == "111")
            {
                turno = 3;
            }
            else if (lblModulo.Text == "112" || lblModulo.Text == "113" || lblModulo.Text == "116")
            {
                turno = 4;
            }
            else if (lblModulo.Text == "115" || lblModulo.Text == "117" || lblModulo.Text == "120")
            {
                turno = 5;
            }
            else if (lblModulo.Text == "107" || lblModulo.Text == "126" || lblModulo.Text == "127")
            {
                turno = 6;
            }
            else if (lblModulo.Text == "108" || lblModulo.Text == "114" || lblModulo.Text == "125")
            {
                turno = 7;
            }
            else if (lblModulo.Text == "122")
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


        //Función que inserta datos en 0 cuando la la tabla de control está vacía


        private void insertarPrimerDatoDelDia()
        {
            DataTable tablaProduccionModulo = datosTablaProduccionModulo();
            DataTable tablaOrdenDeProduccion = datosTablaOrdenDeProduccion();
            int minutosTrabajados = 20;

            float sam = encontrarUltimaFilaColumna<float>(tablaOrdenDeProduccion, "Sam");

            objProduccionModulo.CantidadPersonas = encontrarUltimaFilaColumna<int>(tablaProduccionModulo, "CantidadPersonas");
            objProduccionModulo.Fecha = Convert.ToDateTime(DateTime.Now.ToString("d"));
            objProduccionModulo.Hora = Convert.ToDateTime(DateTime.Now.ToString("t"));
            objProduccionModulo.TiempoPrenda = Convert.ToDouble(sam / objProduccionModulo.CantidadPersonas);
            objProduccionModulo.UnidadesFaltantes = encontrarUltimaFilaColumna<int>(tablaProduccionModulo, "UnidadesFaltantes");
            objProduccionModulo.UnidadesFabricadas = 0;
            objProduccionModulo.NoConformes = 0;
            objProduccionModulo.PorcentajeParcial = 0;
            objProduccionModulo.PorcentajeAcumulado = 0;
            objProduccionModulo.UnidadesPorHora = 0;
            objProduccionModulo.Revision = false;
            objProduccionModulo.Comentarios = "";
            objProduccionModulo.TotalFabricadas = encontrarUltimaFilaColumna<int>(tablaProduccionModulo, "TotalFabricadas");


            int totalFabricadas = encontrarUltimaFilaColumna<int>(tablaProduccionModulo, "TotalFabricadas");
            if (totalFabricadas == -9999)
            {
                totalFabricadas = 0;
            }
            else
            {
                totalFabricadas = encontrarUltimaFilaColumna<int>(tablaProduccionModulo, "TotalFabricadas");
            }
            objProduccionModulo.TotalFabricadas = totalFabricadas;

            string codigoOrdenDeProduccion = objNegocioOrdenProduccion.obtenerCodigoOrden(lblModulo.Text);

            objNegocioProduccionModulo.InsertarProduccionModulo(objProduccionModulo, codigoOrdenDeProduccion);
            CargarDatosEnFormulario();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (panelActualizarInfo.Visible == false)
            {
                panelActualizarInfo.Visible = true;            
            }
            else
            {
                panelActualizarInfo.Visible = false;
            }
            
        }

        private void btnMecanico_Click(object sender, EventArgs e)
        {
            frmPresentacionInicioPrincipal.llamadaMecanico = true;
        }

        private void dtpFechaModuloBuscar_ValueChanged(object sender, EventArgs e)
        {
            CargarDatosEnFormulario();
        }

        public void ConvertirColumnaAEnteros(DataTable dataTable, string nombreColumna)
        {
            DataColumn columna = dataTable.Columns[nombreColumna];

            foreach (DataRow row in dataTable.Rows)
            {
                if (row[columna] != DBNull.Value)
                {
                    double valorTabla = Convert.ToSingle(row[columna]);

                    int valorEntero = (int)valorTabla;

                    row[columna] = valorEntero;
                }
            }
        }
    }
}