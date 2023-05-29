using CapaNegocio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPresentacionInicioPrincipal : Form
    {
        NegocioProduccionModulo objNegocioProduccionModulo = new NegocioProduccionModulo();
        public static bool llamadaMecanico;

        public frmPresentacionInicioPrincipal()
        {
            InitializeComponent();
            unidadesYEficienciaPlanta();
        }

        private const int TamañoGrid = 10;
        private const int AreaMouse = 132;
        private const int BotonIzquierdo = 17;
        private Rectangle RectanguloGrid;

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, ClientRectangle.Width, ClientRectangle.Height));
            RectanguloGrid = new Rectangle(ClientRectangle.Width - TamañoGrid, ClientRectangle.Height - TamañoGrid, TamañoGrid, TamañoGrid);
            region.Exclude(RectanguloGrid);

            panelPrincipal.Region = region;
            Invalidate();
        }

        protected override void WndProc(ref Message sms)
        {
            switch (sms.Msg)
            {
                case AreaMouse:
                    base.WndProc(ref sms);
                    var RefPoint = PointToClient(new Point(sms.LParam.ToInt32() & 0xffff, sms.LParam.ToInt32() >> 16));
                    if (!RectanguloGrid.Contains(RefPoint))
                    {
                        break;
                    }
                    sms.Result = new IntPtr(BotonIzquierdo);
                    break;
                default:
                    base.WndProc(ref sms);
                    break;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush solidBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(solidBrush, RectanguloGrid);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, RectanguloGrid);
        }



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            //transicion del panel 

            if (panelMenu.Width == 60)
            {
                panelMenu.Visible = false;
                panelMenu.Width = 215;
                panelTransicion.ShowSync(panelMenu);
                panelTransicionLogo.ShowSync(label1);

            }
            else
            {
                panelTransicionLogo.Hide(label1);
                panelMenu.Visible = false;
                panelMenu.Width = 60;
                panelTransicion.ShowSync(panelMenu);
            }
        }

        int lx, ly;
        int sw, sh;

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            Size = new Size(sw, sh);
            Location = new Point(lx, ly);
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AbrirFromulario(new frmDashboar());
        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            AbrirFromulario(new frmDashBoardReal());
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnControlPiso_Click(object sender, EventArgs e)
        //evento click para llamar frmaccesocontrolpiso
        {
            AbrirFromulario(new frmAccesosControlPiso());
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void panelMenus_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCalidad_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            AbrirFromulario(new frmIngresoInfo());
        }

        private void btnMecanico_click(object sender, EventArgs e)
        {
            AbrirFromulario(new frmMecanico());
        }

        private void frmPresentacionInicioPrincipal_Resize(object sender, EventArgs e)
        {
            // Obtener el tamaño de la pantalla
            Screen screen = Screen.FromControl(this);
            Rectangle workingArea = screen.WorkingArea;

            // Ajustar el tamaño y la posición del formulario
            this.Size = new Size(workingArea.Width, workingArea.Height);
            this.Location = new Point(workingArea.Left, workingArea.Top);

            // Ajustar el tamaño y la posición de los controles internos según sea necesario
            // ...
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            unidadesYEficienciaPlanta();
        }

        public void unidadesYEficienciaPlanta()
        {            
            
            int unidadesNave1 = objNegocioProduccionModulo.ObtenerTotalUnidadesFabricadasPorNave("1", DateTime.Now);
            float esperadasNave1 = objNegocioProduccionModulo.ObtenerTotalUnidadesEsperadasPorNave("1", DateTime.Now);

            int unidadesNave2 = objNegocioProduccionModulo.ObtenerTotalUnidadesFabricadasPorNave("2", DateTime.Now);
            float esperadasNave2 = objNegocioProduccionModulo.ObtenerTotalUnidadesEsperadasPorNave("2", DateTime.Now);

            int unidadesNave3 = objNegocioProduccionModulo.ObtenerTotalUnidadesFabricadasPorNave("3", DateTime.Now);
            float esperadasNave3 = objNegocioProduccionModulo.ObtenerTotalUnidadesEsperadasPorNave("3", DateTime.Now);

            int unidadesNave4 = objNegocioProduccionModulo.ObtenerTotalUnidadesFabricadasPorNave("4", DateTime.Now);
            float esperadasNave4 = objNegocioProduccionModulo.ObtenerTotalUnidadesEsperadasPorNave("4", DateTime.Now);

            int sumaUnidadesFabricadasPlanta = unidadesNave1 + unidadesNave2 + unidadesNave3 + unidadesNave4;
            float sumaUnidadesEsperadasPlanta = esperadasNave1 + esperadasNave2 + esperadasNave3 + esperadasNave4;

            lblUnidadesEsperadas.Text = sumaUnidadesEsperadasPlanta.ToString();
            lblEficienciaOcumuladaPlanta.Text = Math.Truncate((sumaUnidadesFabricadasPlanta / sumaUnidadesEsperadasPlanta)*100).ToString() + "%";
            lblTotalPrendasFabricadasPlanta.Text = sumaUnidadesFabricadasPlanta.ToString();
        }
        

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = Location.X;
            ly = Location.Y;
            sw = Size.Width;
            sh = Size.Height;
            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;


        }
        public void AbrirFromulario(object formhijo)
        //metodo para abrir formularios del menu 
        {
            if (this.btnMecanico.Controls.Count > 0)
                this.btnMecanico.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.btnMecanico.Controls.Add(fh);
            this.btnMecanico.Tag = fh;
            fh.Show();
        }

    }
}
