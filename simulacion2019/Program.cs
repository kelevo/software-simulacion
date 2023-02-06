using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulacion2019
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
            INICIO ini = new INICIO();
            if(ini.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Form1());  
            }

                //Application.Run(new Form1());
        }

    }
}
