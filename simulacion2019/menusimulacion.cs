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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCuadradosMedios_Click(object sender, EventArgs e)
        {
            AlgCuadradosMedios algcuadradosmedios = new AlgCuadradosMedios();
            algcuadradosmedios.ShowDialog();
        }

        private void BtnAlgProductosMedios_Click(object sender, EventArgs e)
        {
            AlgProductosMedios algproductosmedios = new AlgProductosMedios();
            algproductosmedios.ShowDialog();
        }

        private void btnProductoMedioModificado_Click(object sender, EventArgs e)
        {

            AlgProductoMedioModificado algproductomediomodificado = new AlgProductoMedioModificado();
            algproductomediomodificado.ShowDialog();
        }

        private void btnUsarMetodoNeumann_Click(object sender, EventArgs e)
        {
            MetodoNeumann metodoneumann = new MetodoNeumann();
            metodoneumann.ShowDialog();
        }

        private void btnMetodoCongruencial_Click(object sender, EventArgs e)
        {
            GeneradorMetodoCongruencial metodocongruencial = new GeneradorMetodoCongruencial();
            metodocongruencial.ShowDialog();
        }

        private void btnMetodoCongruencialMultiplicativo_Click(object sender, EventArgs e)
        {
            MetodoCongMultiplica conmultiplica = new MetodoCongMultiplica();
            conmultiplica.ShowDialog();
        }

        private void btnMetodoCongruencialAditivo_Click(object sender, EventArgs e)
        {
            MetodoCongAditivo conaditivo = new MetodoCongAditivo();
            conaditivo.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prueba_de_la_Varianza varianza = new Prueba_de_la_Varianza();
            varianza.ShowDialog();
        }

        private void btnMontecarlo_Click(object sender, EventArgs e)
        {
            montecarlo algcuadradosmedios = new montecarlo();
            algcuadradosmedios.ShowDialog();
        }

        private void btnExponencial_Click(object sender, EventArgs e)
        {
            Mexponencial expo = new Mexponencial();
            expo.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnPoisson_Click(object sender, EventArgs e)
        {
            Mpoisson poisson = new Mpoisson();
            poisson.ShowDialog();
        }

        private void btnConvolucion_Click(object sender, EventArgs e)
        {
            Mconvolucion convolucion = new Mconvolucion();
            convolucion.ShowDialog();
        }
    }
}
