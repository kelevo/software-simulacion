using CuadradosMedios;
using MetodosComunes;
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
    public partial class MetodoCongMultiplica : Form
    {
        public MetodoCongMultiplica()
        {
            InitializeComponent();
        }

        private void btnGenerarCongMulti_Click(object sender, EventArgs e)
        {
            
            double Semilla, k, Modulo, N, g, a;

            Semilla = double.Parse(txtSemillaMulti.Text);
            k = double.Parse(txtConstanteCongMulti.Text);
            g = double.Parse(txtValorg.Text);
            Modulo = Math.Pow(2, g);
            N = int.Parse(txtGeneCongMulti.Text);
            a = (5 + (8 * k));

            txtModuloCongMulti.Text = (Modulo.ToString());

            for (int i = 1; i < N; i++)
            {
                
                Semilla = (a * Semilla) % Modulo;
                listBox2.Items.Add(Semilla);
                double nuevo = (Semilla / (Modulo - 1));
                listBox1.Items.Add("0." + nuevo);

            }

           
        }

        private void MetodoCongMultiplica_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtConstanteCongMulti.Clear();
            txtGeneCongMulti.Clear();
            txtModuloCongMulti.Clear();
            txtSemillaMulti.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
           
        }
    }
 }
    
