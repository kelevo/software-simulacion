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
    public partial class MetodoNeumann : Form
    {
        public MetodoNeumann()
        {
            InitializeComponent();
        }

        private void btnGenerarNeumann_Click(object sender, EventArgs e)
        {

            double semilla, cantidad;
            semilla = double.Parse(txtSemilla10digitos.Text);
            cantidad = double.Parse(txtNumerosGenerarNeumann.Text);
            double semilla_total=0;

            string semillaText = semilla.ToString();
            int D = semillaText.Length;

            for (int i = 0; i < cantidad; i++)
            {
                semilla_total =  Math.Pow(semilla, 2);
                int l;
                l = semilla_total.ToString().Length;
                semillaText = semilla_total.ToString(); 
                semillaText = semillaText.Substring( (l/2)-2,5);
                               
                semilla = double.Parse(semillaText);

                listBox1.Items.Add(semilla_total);
                listBox2.Items.Add("0." + semilla);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNumerosGenerarNeumann.Clear();
            txtSemilla10digitos.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
