using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulacion2019
{
    public partial class MetodoCongAditivo : Form
    {
        //DECLARACION DE VARIABLES

        double r1, r2, r3, r4, r5, r6, r7; //Numeros pseudoaleatorios a generar

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listBoxCongAditivo.Items.Clear();
            listBoxCongAditivo.Items.Clear();
            listBoxCongAditivo.Items.Clear();
            listBoxCongAditivo.Items.Clear();
            listBoxCongAditivo.Items.Clear();
            listBoxCongAditivo.Items.Clear();
            listBoxCongAditivo.Items.Clear();
        }

        int x1, x2, x3, x4, x5, modo; //Valores iniciales a introducir

        double x6, x7, x8, x9, x10, x11, x12; //Numeros ejemplos que pide

        public MetodoCongAditivo()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if ((txtValInicial1.Equals("")) || (txtValInicial2.Equals("")) || (txtValInicial3.Equals("")) || (txtValInicial4.Equals("")) || (txtValInicial5.Equals("")) || (txtModo.Equals(""))){

                MessageBox.Show("Completa los campos");

            }

            else
            {
                x1 = int.Parse(txtValInicial1.Text);
                x2 = int.Parse(txtValInicial2.Text);
                x3 = int.Parse(txtValInicial3.Text);
                x4 = int.Parse(txtValInicial4.Text);
                x5 = int.Parse(txtValInicial5.Text);
                modo = int.Parse(txtModo.Text);

                x6 = (x5 + x1) % modo;
                x7 = (x6 + x2) % modo;
                x8 = (x7 + x3) % modo;
                x9 = (x8 + x4) % modo;
                x10 = (x9 + x5) % modo;
                x11 = (x10 + x6) % modo;
                x12 = (x11 + x7) % modo;

                r1 = x6 / (modo - 1);
                r2 = x7 / (modo - 1);
                r3 = x8 / (modo - 1);
                r4 = x9 / (modo - 1);
                r5 = x10 / (modo - 1);
                r6 = x11 / (modo - 1);
                r7 = x12 / (modo - 1);

                listBoxCongAditivo.Items.Add("0. " + r1);
                listBoxCongAditivo.Items.Add("0. " + r2);
                listBoxCongAditivo.Items.Add("0. " + r3);
                listBoxCongAditivo.Items.Add("0. " + r4);
                listBoxCongAditivo.Items.Add("0. " + r5);
                listBoxCongAditivo.Items.Add("0. " + r6);
                listBoxCongAditivo.Items.Add("0. " + r7);
            }

                
        }
    }
}
