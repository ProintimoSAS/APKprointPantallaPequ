using CapaNegocio;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmAccesosControlPiso : Form
    {

        NegocioOrdenDeProduccion objNegocioOrdenProduccion = new NegocioOrdenDeProduccion();

        public frmAccesosControlPiso()

        {
            InitializeComponent();
        }
        //esta variable me almacena la variable con el numero del modulo para llevaro a otro formulario
        public static string numeroModulo;

        private void btnNave1_Click_1(object sender, EventArgs e)
        {

          TransitionModulo1.ShowSync(panelModulosNave1);

        }


        private void btnNave2_Click(object sender, EventArgs e)
        {

            TransitionModulo2.ShowSync(panelModulosNave2);

        }

        private void bunifuCustomLabel16_Click(object sender, EventArgs e)
        {

        }

        private void btnNave3_Click(object sender, EventArgs e)
        {
            TransitionModulo3.ShowSync(panelModulosNave3);
        }

        private void btnNave4_Click(object sender, EventArgs e)
        {
            TransitionModulo4.ShowSync(panelModulosNave4);

        }

        public void Llamarfrmcontrolpiso()
        {
            frmPresentacionInicioPrincipal frm = (frmPresentacionInicioPrincipal)Application.OpenForms["frmPresentacionInicioPrincipal"]; 
            frm.AbrirFromulario(new frmControlPiso());            
        }

        public void LlamarfrmIngresoInfo()
        {
            frmPresentacionInicioPrincipal frm = (frmPresentacionInicioPrincipal)Application.OpenForms["frmPresentacionInicioPrincipal"];            
            frm.AbrirFromulario(new frmIngresoInfo());            
        }

        public void Llamarfrm(string modulo)
        {
            //objNegocioOrdenProduccion.obtenerOrdenesDeProduccion(modulo);

            int cantidadFilasTablaOrden = objNegocioOrdenProduccion.obtenerOrdenesDeProduccion(modulo).Rows.Count;

            if (cantidadFilasTablaOrden == 0)
            {
                LlamarfrmIngresoInfo();
            }
            else
            {
                Llamarfrmcontrolpiso();
            }

        }


        private void btnModulo1_Click(object sender, EventArgs e)
        {
            string NumeroModulo = "102";

            numeroModulo = NumeroModulo;

            Llamarfrm(NumeroModulo);
        }

        private void btnModulo2_Click_1(object sender, EventArgs e)
        {
            string NumeroModulo = "103";

            numeroModulo = NumeroModulo;

            Llamarfrm(NumeroModulo);

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            string NumeroModulo = "105";

            numeroModulo = NumeroModulo;

            Llamarfrm(NumeroModulo);
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            string NumeroModulo = "106";

            numeroModulo = NumeroModulo;

            Llamarfrm(NumeroModulo);
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            string NumeroModulo = "110";

            numeroModulo = NumeroModulo;

            Llamarfrm(NumeroModulo);
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            string NumeroModulo = "118";

            numeroModulo = NumeroModulo;

            Llamarfrm(NumeroModulo);
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            string NumeroModulo = "200";
            numeroModulo = NumeroModulo;
            Llamarfrm(NumeroModulo);
        }

        private void bunifuImageButton15_Click(object sender, EventArgs e)
        {
            string NumeroModulo = "104";

            numeroModulo = NumeroModulo;

            Llamarfrm(NumeroModulo);
        }

        private void bunifuImageButton14_Click(object sender, EventArgs e)
        {
            string NumeroModulo = "111";

            numeroModulo = NumeroModulo;

            Llamarfrm(NumeroModulo);
        }

        private void bunifuImageButton13_Click(object sender, EventArgs e)
        {
            string NumeroModulo = "112";

            numeroModulo = NumeroModulo;

            Llamarfrm(NumeroModulo);
        }

        private void bunifuImageButton11_Click(object sender, EventArgs e)
        {
            string NumeroModulo = "113";

            numeroModulo = NumeroModulo;

            Llamarfrm(NumeroModulo);
        }

        private void bunifuImageButton12_Click(object sender, EventArgs e)
        {
            string NumeroModulo = "116";

            numeroModulo = NumeroModulo;

            Llamarfrm(NumeroModulo);
        }

        private void btnModulo208_Click(object sender, EventArgs e)
        {
            string NumeroModulo = "115";

            numeroModulo = NumeroModulo;

            Llamarfrm(NumeroModulo);
        }

        private void bunifuImageButton22_Click(object sender, EventArgs e)
        {
            string NumeroModulo = "117";

            numeroModulo = NumeroModulo;

            Llamarfrm(NumeroModulo);
        }

        private void bunifuImageButton21_Click(object sender, EventArgs e)
        {
            string NumeroModulo = "120";

            numeroModulo = NumeroModulo;

            Llamarfrm(NumeroModulo);
        }

        private void bunifuImageButton19_Click(object sender, EventArgs e)
        {
            string NumeroModulo = "126";

            numeroModulo = NumeroModulo;

            Llamarfrm(NumeroModulo);
        }

        private void bunifuImageButton20_Click(object sender, EventArgs e)
        {
            string NumeroModulo = "127";

            numeroModulo = NumeroModulo;

            Llamarfrm(NumeroModulo);
        }

        private void bunifuImageButton31_Click(object sender, EventArgs e)
        {
            string NumeroModulo = "107";

            numeroModulo = NumeroModulo;

            Llamarfrm(NumeroModulo);
        }

        private void bunifuImageButton30_Click(object sender, EventArgs e)
        {
            string NumeroModulo = "108";

            numeroModulo = NumeroModulo;

            Llamarfrm(NumeroModulo);
        }

        private void bunifuImageButton29_Click(object sender, EventArgs e)
        {
            string NumeroModulo = "114";

            numeroModulo = NumeroModulo;

            Llamarfrm(NumeroModulo);
        }

        private void bunifuImageButton27_Click(object sender, EventArgs e)
        {
            string NumeroModulo = "121";

            numeroModulo = NumeroModulo;

            Llamarfrm(NumeroModulo);
        }

        private void bunifuImageButton28_Click(object sender, EventArgs e)
        {
            string NumeroModulo = "122";

            numeroModulo = NumeroModulo;

            Llamarfrm(NumeroModulo);
        }

        private void bunifuImageButton26_Click(object sender, EventArgs e)
        {
            string NumeroModulo = "125";

            numeroModulo = NumeroModulo;

            Llamarfrm(NumeroModulo);
        }
    }
}
