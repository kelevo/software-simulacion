using CuadradosMedios;
using MetodosComunes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulacion2019
{
    public partial class AlgProductosMedios : Form
    {
        private int semilla;
        private int semilla2;

        public AlgProductosMedios()
        {
            InitializeComponent();
        }

        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double semilla, cantidad;
            semilla = int.Parse(textBox1.Text);
            semilla2 = int.Parse(textBox2.Text);
            cantidad = int.Parse(textBox3.Text);
            double semilla_total = 0;

            for (int i = 0; i < cantidad; i++)
            {
                semilla_total = semilla * semilla2;
                string Nsemilla_total;
                Nsemilla_total = Convert.ToString(semilla_total);
                String D4;
                D4 = Nsemilla_total.Substring(2, 4);
                semilla2 = Convert.ToInt32(D4);
                listBox1.Items.Add(semilla_total);
                listBox2.Items.Add("0." + semilla2);
            }
        }

        private void labelSemilla2_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
