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
    public partial class frmMecanico : Form
    {

        public frmMecanico()
        {
            InitializeComponent();
            principal();
        }

        private void btn102_Click(object sender, EventArgs e)
        {

        }

        public void btn102Rojo_Click(object sender, EventArgs e)
        {
            btn102Rojo.Visible = false;
            btn102.Visible = true;
            
        }

        public void activarBoton()
        {
            btn102Rojo.Visible = true;
            btn102.Visible = false;
        }
       
        public void principal()
        {
            if (frmPresentacionInicioPrincipal.llamadaMecanico)
            {
                activarBoton();
            }
        }

    }
}
