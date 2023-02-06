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
    public partial class GeneradorMetodoCongruencial : Form
    {
        public GeneradorMetodoCongruencial()
        {
            InitializeComponent();
        }

        private void btngene_Click(object sender, EventArgs e)
        {
            GeneradorMetodoCongru metodocong = new GeneradorMetodoCongru(int.Parse(txtSemillaCong.Text), int.Parse(txtConstante.Text), int.Parse(txtModulo.Text), int.Parse(txtMultiplicador.Text), int.Parse(txtNumGene.Text));

            ProcesaAleatorios procesador = new ProcesaAleatorios();
            textBox1.Text = (procesador.CreaTexto(metodocong.Aleatorios) + Environment.NewLine);
            MessageBox.Show("Proceso terminado con éxito", "Generador de Aleatorios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GeneradorMetodoCongruencial_Load(object sender, EventArgs e)
        {

        }

        private void txtMultiplicador_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConstante_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtConstante.Clear();
            txtModulo.Clear();
            txtMultiplicador.Clear();
            txtNumGene.Clear();
            txtSemillaCong.Clear();
            textBox1.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
