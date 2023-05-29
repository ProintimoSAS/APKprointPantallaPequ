using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmAccesosControlPiso());
            //Application.Run(new frmControlPiso());

             Application.Run(new frmPresentacionInicioPrincipal());

            //Application.Run(new frmIngresoEmpleado());
            //Application.Run(new FrmControlPisoF());
            //Application.Run(new frmPresentacionIngreso());
            //Application.Run(new frmCalidad());


        }
    }
}
