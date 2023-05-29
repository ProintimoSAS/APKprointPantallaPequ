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
    public partial class frmDashBoardReal : Form
    {
        NegocioProduccionModulo objNegocioProduccionModulo = new NegocioProduccionModulo();
        NegocioOrdenDeProduccion objNegocioOrdenDeProduccion = new NegocioOrdenDeProduccion();
        public frmDashBoardReal()
        {
            InitializeComponent();
            cargar();
        }

        public void cargar()
        {
            graficoPorcentajeNave1();
            graficoPorcentajeNave2();
            graficoPorcentajeNave3();
            graficoPorcentajeNave4();
            cargarInformacionModulos();
            unidadesYEficienciaPlanta();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            cargar();
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

        public void graficoPorcentajeNave1()
        {


            int unidadesNave1 = objNegocioProduccionModulo.ObtenerTotalUnidadesFabricadasPorNave("1", dtpFechaAMostrar.Value);
            float esperadasRealesNave1 = objNegocioProduccionModulo.ObtenerTotalUnidadesEsperadasReales("1", dtpFechaAMostrar.Value);


            int variabled;

            variabled = (int)((unidadesNave1 / esperadasRealesNave1) * 100);
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
            else if (ProgressBar1.Value >= 80)
            {
                ProgressBar1.ProgressColor = Color.Green;
            }

            if (ProgressBar1.Value == variabled)
            {
                timer1.Enabled = false;
            }
        }

        public void graficoPorcentajeNave2()
        {
            int unidadesNave2 = objNegocioProduccionModulo.ObtenerTotalUnidadesFabricadasPorNave("2", dtpFechaAMostrar.Value);
            float esperadasRealesNave2 = objNegocioProduccionModulo.ObtenerTotalUnidadesEsperadasReales("2", dtpFechaAMostrar.Value);


            int variabled;

            variabled = (int)((unidadesNave2 / esperadasRealesNave2) * 100);
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
                timer1.Enabled = false;
            }
        }

        public void graficoPorcentajeNave3()
        {
            int unidadesNave3 = objNegocioProduccionModulo.ObtenerTotalUnidadesFabricadasPorNave("3", dtpFechaAMostrar.Value);
            float esperadasRealesNave3 = objNegocioProduccionModulo.ObtenerTotalUnidadesEsperadasReales("3", dtpFechaAMostrar.Value);


            int variabled;

            variabled = (int)((unidadesNave3 / esperadasRealesNave3) * 100);
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
                timer1.Enabled = false;
            }
        }

        public void graficoPorcentajeNave4()
        {
            int unidadesNave4 = objNegocioProduccionModulo.ObtenerTotalUnidadesFabricadasPorNave("4", dtpFechaAMostrar.Value);
            float esperadasRealesNave4 = objNegocioProduccionModulo.ObtenerTotalUnidadesEsperadasReales("4", dtpFechaAMostrar.Value);


            int variabled;

            variabled = (int)((unidadesNave4 / esperadasRealesNave4) * 100);
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
                timer1.Enabled = false;
            }
        }

        

        public double quitarDecimales(double numeroAQuitarDecimales)
        {
            return Math.Truncate(numeroAQuitarDecimales);
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
            int rowCount = tabla.Rows.Count;

            if (rowCount > 0)
            {
                DataRow lastRow = tabla.Rows[rowCount - 1];

                try
                {
                    object lastValue = lastRow[columna];

                    if (lastValue != DBNull.Value)
                    {
                        return (T)Convert.ChangeType(lastValue, typeof(T));
                    }
                }
                catch (Exception)
                {
                    // Manejar excepción cuando la columna no existe
                }
            }
            return default(T);
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
                if (cantidadFilasTablaProduccion == 0)
                {
                    labelEficiencia.Text = "0";
                }

                labelEficiencia.Text = Convert.ToInt32(encontrarUltimaFilaColumna<float>(tablaProduccion, "PorcentajeAcumuladoReal")).ToString();

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
            cargar();
        }

        public double totalUnidadesFabricadas(string modulo)
        {
            double totalFabricadas = 0;
            for (int i = 0; i < datosTablaProduccionModulo(modulo).Rows.Count; i++)
            {
                totalFabricadas += Convert.ToDouble(datosTablaProduccionModulo(modulo).Rows[i]["UnidadesFabricadas"]);
            }
            return totalFabricadas;
        }

        public double totalUnidadesDejadasDeFabricadas(string modulo)
        {
            double totalFabricadas = 0;
            for (int i = 0; i < datosTablaProduccionModulo(modulo).Rows.Count; i++)
            {
                totalFabricadas += Convert.ToDouble(datosTablaProduccionModulo(modulo).Rows[i]["UnidadesDejadasDeFabricar"]);
            }
            return totalFabricadas;
        }

        public void TotalFabricadasPorModulo(Label label, string modulo)
        {
            label.Text = totalUnidadesFabricadas(modulo).ToString();
        }

        public int totalUnidadesPlanta()
        {
            return int.Parse(lblSumaTotalVeroni.Text) + int.Parse(lblSumaTotalLuci.Text) + int.Parse(lblSumaTotalYola.Text) + int.Parse(lblSumaTotalLeid.Text);
        }

        public void unidadesYEficienciaPlanta()
        {
            int unidadesNave1 = objNegocioProduccionModulo.ObtenerTotalUnidadesFabricadasPorNave("1", dtpFechaAMostrar.Value);
            float esperadasRealNave1 = objNegocioProduccionModulo.ObtenerTotalUnidadesEsperadasReales("1", dtpFechaAMostrar.Value);

            int unidadesNave2 = objNegocioProduccionModulo.ObtenerTotalUnidadesFabricadasPorNave("2", dtpFechaAMostrar.Value);
            float esperadasRealNave2 = objNegocioProduccionModulo.ObtenerTotalUnidadesEsperadasReales("2", dtpFechaAMostrar.Value);

            int unidadesNave3 = objNegocioProduccionModulo.ObtenerTotalUnidadesFabricadasPorNave("3", dtpFechaAMostrar.Value);
            float esperadasRealNave3 = objNegocioProduccionModulo.ObtenerTotalUnidadesEsperadasReales("3", dtpFechaAMostrar.Value);

            int unidadesNave4 = objNegocioProduccionModulo.ObtenerTotalUnidadesFabricadasPorNave("4", dtpFechaAMostrar.Value);
            float esperadasRealNave4 = objNegocioProduccionModulo.ObtenerTotalUnidadesEsperadasReales("4", dtpFechaAMostrar.Value);

            int sumaUnidadesFabricadasPlanta = unidadesNave1 + unidadesNave2 + unidadesNave3 + unidadesNave4;
            float sumaUnidadesEsperadasReal = esperadasRealNave1 + esperadasRealNave2 + esperadasRealNave3 + esperadasRealNave4;

            
            lblUnidadesEsperadas.Text = sumaUnidadesEsperadasReal.ToString();
            lblEficienciaReal.Text = Math.Truncate((sumaUnidadesFabricadasPlanta / sumaUnidadesEsperadasReal) * 100).ToString() + "%";
            lblUnidadesFabricadas.Text = sumaUnidadesFabricadasPlanta.ToString();

            int dejadasDeFabricar = (int)sumaUnidadesEsperadasReal - sumaUnidadesFabricadasPlanta;

            if (dejadasDeFabricar < 0)
            {
                dejadasDeFabricar = 0;
            }

            lblDejadasDeFabricar.Text = dejadasDeFabricar.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            graficoPorcentajeNave2();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            graficoPorcentajeNave3();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            graficoPorcentajeNave4();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            graficoPorcentajeNave1();
        }
    }
}
