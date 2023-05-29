using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmDashboar : Form
    {
        NegocioOrdenDeProduccion objNegocioOrdenDeProduccion = new NegocioOrdenDeProduccion();
        NegocioProduccionModulo objNegocioProduccionModulo = new NegocioProduccionModulo();


        public frmDashboar()
        {
            InitializeComponent();
            cargarInformacionModulos();
            graficoPorcentajeNave1();
            graficoPorcentajeNave2();
            graficoPorcentajeNave3();
            graficoPorcentajeNave4();
        }


        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("t");
            lblFecha.Text = DateTime.Now.ToString("d");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            graficoPorcentajeNave1();
            graficoPorcentajeNave2();
            graficoPorcentajeNave3();
            graficoPorcentajeNave4();
            cargarInformacionModulos();
        }

        public void cargarInformacionModulos()
        {
            InformacionModulo(lblEficiencia102, lblComentario102, lblFabri102, "102");
            InformacionModulo(lblEficiencia103, lblComentario103, lblFabri103, "103");
            InformacionModulo(lblEficiencia105, lblComentario105, lblFabri105, "105");
            InformacionModulo(lblEficiencia106, lblComentario106, lblFabri106, "106");
            InformacionModulo(lblEficiencia110, lblComentario110, lblFabri110, "110");
            InformacionModulo(lblEficiencia118, lblComentario118, lblFabri118, "118");
            InformacionModulo(lblEficiencia200, lblComentario200, lblFabri200, "200");

            InformacionModulo(lblEficiencia104, lblComentario104, lblFabri104, "104");
            InformacionModulo(lblEficiencia111, lblComentario111, lblFabri111, "111");
            InformacionModulo(lblEficiencia112, lblComentario112, lblFabri112, "112");
            InformacionModulo(lblEficiencia113, lblComentario113, lblFabri113, "113");
            InformacionModulo(lblEficiencia116, lblComentario116, lblFabri116, "116");

            InformacionModulo(lblEficiencia115, lblComentario115, lblFabri115, "115");
            InformacionModulo(lblEficiencia117, lblComentario117, lblFabri117, "117");
            InformacionModulo(lblEficiencia120, lblComentario120, lblFabri120, "120");
            InformacionModulo(lblEficiencia126, lblComentario126, lblFabri126, "126");
            InformacionModulo(lblEficiencia127, lblComentario127, lblFabri127, "127");

            InformacionModulo(lblEficiencia107, lblComentario107, lblFabri107, "107");
            InformacionModulo(lblEficiencia108, lblComentario108, lblFabri108, "108");
            InformacionModulo(lblEficiencia114, lblComentario114, lblFabri114, "114");
            InformacionModulo(lblEficiencia122, lblComentario122, lblFabri122, "122");
            InformacionModulo(lblEficiencia125, lblComentario125, lblFabri125, "125");


            lblSumaTotalVeroni.Text = objNegocioProduccionModulo.ObtenerTotalUnidadesFabricadasPorNave("1", dtpFechaAMostrar.Value).ToString();
            lblSumaTotalLuci.Text = objNegocioProduccionModulo.ObtenerTotalUnidadesFabricadasPorNave("2", dtpFechaAMostrar.Value).ToString();
            lblSumaTotalYola.Text = objNegocioProduccionModulo.ObtenerTotalUnidadesFabricadasPorNave("3", dtpFechaAMostrar.Value).ToString();
            lblSumaTotalLeid.Text = objNegocioProduccionModulo.ObtenerTotalUnidadesFabricadasPorNave("4", dtpFechaAMostrar.Value).ToString();

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            graficoPorcentajeNave1();
        }

        public void graficoPorcentajeNave1()
        {
            int unidadesNave1 = objNegocioProduccionModulo.ObtenerTotalUnidadesFabricadasPorNave("1", dtpFechaAMostrar.Value);
            float esperadasNave1 = objNegocioProduccionModulo.ObtenerTotalUnidadesEsperadasPorNave("1", dtpFechaAMostrar.Value);
            
            int variabled;

            variabled = (int)((unidadesNave1 / esperadasNave1)*100);
            if (variabled < 0)
            {
                variabled = 0;
            }

            if (variabled >= 99)
            {
                ProgressBar1.Maximum = variabled;
            }
            if (variabled < 99)
            {
                ProgressBar1.Maximum = 100;
            }
            if (variabled < 0)
            {
                ProgressBar1.Minimum = variabled;
            }

            ProgressBar1.Value = variabled;
            ProgressBar1.Text = ProgressBar1.Value.ToString() + "%";


            if (ProgressBar1.Value >= 0 && ProgressBar1.Value <= 59)
            {
                ProgressBar1.ProgressColor = Color.Red;
            }
            else if (ProgressBar1.Value >= 60 && ProgressBar1.Value <= 79)
            {
                ProgressBar1.ProgressColor = Color.Yellow;
            }
            else if (ProgressBar1.Value >= 80 )
            {
                ProgressBar1.ProgressColor = Color.Green;
            }                     

            if (ProgressBar1.Value == variabled)
            {
                timer1.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            graficoPorcentajeNave2();
        }

        public void graficoPorcentajeNave2()
        {
            int unidadesNave2 = objNegocioProduccionModulo.ObtenerTotalUnidadesFabricadasPorNave("2", dtpFechaAMostrar.Value);
            float esperadasNave2 = objNegocioProduccionModulo.ObtenerTotalUnidadesEsperadasPorNave("2", dtpFechaAMostrar.Value);


            int variabled;

            variabled = (int)((unidadesNave2 / esperadasNave2) * 100);
            if (variabled < 0)
            {
                variabled = 0;
            }


            if (variabled >= 99)
            {
                ProgressBar2.Maximum = variabled;
            }
            if (variabled < 99)
            {
                ProgressBar2.Maximum = 100;
            }
            if (variabled < 0)
            {
                ProgressBar2.Minimum = variabled;
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

        private void timer3_Tick(object sender, EventArgs e)
        {
            graficoPorcentajeNave3();
        }

        public void graficoPorcentajeNave3()
        {
            int unidadesNave3 = objNegocioProduccionModulo.ObtenerTotalUnidadesFabricadasPorNave("3", dtpFechaAMostrar.Value);
            float esperadasNave3 = objNegocioProduccionModulo.ObtenerTotalUnidadesEsperadasPorNave("3", dtpFechaAMostrar.Value);


            int variabled;

            variabled = (int)((unidadesNave3 / esperadasNave3) * 100);
            if (variabled < 0)
            {
                variabled = 0;
            }

            if (variabled >= 99)
            {
                ProgressBar3.Maximum = variabled;
            }
            if (variabled < 99)
            {
                ProgressBar3.Maximum = 100;
            }
            if (variabled < 0)
            {
                ProgressBar3.Minimum = variabled;
            }

            ProgressBar3.Value = variabled;
            ProgressBar3.Text = ProgressBar3.Value.ToString() + "%";


            if (ProgressBar3.Value >= 0 && ProgressBar3.Value <= 59)
            {
                ProgressBar3.ProgressColor = Color.Red;
            }
            else if (ProgressBar3.Value >= 60 && ProgressBar3.Value <= 79)
            {
                ProgressBar3.ProgressColor = Color.Yellow;
            }
            else
            {
                ProgressBar3.ProgressColor = Color.Green;
            }


            if (ProgressBar3.Value == variabled)
            {
                timer3.Enabled = false;
            }
        }


        private void timer4_Tick(object sender, EventArgs e)
        {
            graficoPorcentajeNave4();
        }

        public void graficoPorcentajeNave4()
        {
            int unidadesNave4 = objNegocioProduccionModulo.ObtenerTotalUnidadesFabricadasPorNave("4", dtpFechaAMostrar.Value);
            float esperadasNave4 = objNegocioProduccionModulo.ObtenerTotalUnidadesEsperadasPorNave("4", dtpFechaAMostrar.Value);


            int variabled;

            variabled = (int)((unidadesNave4/ esperadasNave4) * 100);
            if (variabled < 0)
            {
                variabled = 0;
            }

            if (variabled >= 99)
            {
                ProgressBar4.Maximum = variabled;
            }
            if (variabled < 99)
            {
                ProgressBar4.Maximum = 100;
            }
            if (variabled < 0)
            {
                ProgressBar4.Minimum = variabled;
            }

            ProgressBar4.Value = variabled;
            ProgressBar4.Text = ProgressBar4.Value.ToString() + "%";


            if (ProgressBar4.Value >= 0 && ProgressBar4.Value <= 59)
            {
                ProgressBar4.ProgressColor = Color.Red;
            }
            else if (ProgressBar4.Value >= 60 && ProgressBar4.Value <= 79)
            {
                ProgressBar4.ProgressColor = Color.Yellow;
            }
            else
            {
                ProgressBar4.ProgressColor = Color.Green;
            }
            if (ProgressBar4.Value == variabled)
            {
                timer4.Enabled = false;
            }
        }

        public DataTable datosTablaProduccionModulo(string modulo)
        {
            return objNegocioProduccionModulo.obtenerProduccionModuloPorFecha(dtpFechaAMostrar.Value, modulo);
        }

        public DataTable datosTablaOrdenDeProduccion(string modulo)
        {
            return objNegocioOrdenDeProduccion.obtenerOrdenesDeProduccion(modulo);
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

        public void InformacionModulo(Label labelEficiencia, Label labelComentario, Label labelTotalFabricada, string modulo)
        {
            DataTable tablaProduccion = datosTablaProduccionModulo(modulo);
            DataTable tablaOrden = datosTablaOrdenDeProduccion(modulo);
            int cantidadFilasTablaOrden = tablaOrden.Rows.Count;
            int cantidadFilasTablaProduccion = tablaProduccion.Rows.Count;

            //Eficiencia y color Modulo
            if (cantidadFilasTablaOrden == 0)
            {
                labelEficiencia.Text = "-1";
            }
            else
            {
                try
                {
                    labelEficiencia.Text = Convert.ToInt32(encontrarUltimaFilaColumna<float>(tablaProduccion, "PorcentajeAcumulado")).ToString();
                }
                catch (InvalidCastException)
                {
                    labelEficiencia.Text = "0";
                }

                

            }



            if (int.Parse(labelEficiencia.Text) < 60 && int.Parse(labelEficiencia.Text) >= 0)
            {
                labelEficiencia.BackColor = Color.Red;
                labelEficiencia.Text += "%";
            }
            else if (int.Parse(labelEficiencia.Text) < 80 && int.Parse(labelEficiencia.Text) >= 60)
            {
                labelEficiencia.BackColor = Color.Yellow;
                labelEficiencia.Text += "%";
            }
            else if (int.Parse(labelEficiencia.Text) >= 80)
            {
                labelEficiencia.BackColor = Color.Green;
                labelEficiencia.Text += "%";
            }
            else if (int.Parse(labelEficiencia.Text) < 0)
            {
                labelEficiencia.Font = new Font(labelEficiencia.Font.FontFamily, 16f); ;
                labelEficiencia.Text = "ND";
                labelEficiencia.BackColor = Color.AliceBlue;
            }

        
            //Comentraio
            if (cantidadFilasTablaOrden == 0)
            {
                labelComentario.Text = "";
            }
            else
            {
                labelComentario.Text = encontrarUltimaFilaColumna<string>(tablaProduccion, "Comentarios");
            }
        
            //Unidades fabricadas
            double totalFabricadas = 0;
            for (int i = 0; i < tablaProduccion.Rows.Count; i++)
            {
                totalFabricadas += Convert.ToDouble(tablaProduccion.Rows[i]["UnidadesFabricadas"]);
            }
            labelTotalFabricada.Text = totalFabricadas.ToString();
        }


        private void dtpFechaAMostrar_ValueChanged(object sender, EventArgs e)
        {
            graficoPorcentajeNave1();
            graficoPorcentajeNave2();
            graficoPorcentajeNave3();
            graficoPorcentajeNave4();
            cargarInformacionModulos();
        }

    }
}
