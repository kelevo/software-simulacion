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
    public partial class AlgProductoMedioModificado : Form
    {
        public AlgProductoMedioModificado()
        {
            InitializeComponent();
        }

        private void btnGenerarProductosMediosModificados_Click(object sender, EventArgs e)
        {
             GeneradorProductoMedioModificado gen3 = new GeneradorProductoMedioModificado(float.Parse(txtValorSemilla.Text), int.Parse(txtNumerosGenerar3.Text), float.Parse(txtValork.Text));

            if (gen3.GeneradosConExito)
            {
                ProcesaAleatorios procesador = new ProcesaAleatorios();
                txtMostrarNumerosMedio.Text = (procesador.CreaTexto(gen3.Aleatorios));
                MessageBox.Show("Proceso terminado con éxito", "Generador de Aleatorios", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                MessageBox.Show(gen3.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtValork_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtValorSemilla .Clear();
            txtValork.Clear();
            txtNumerosGenerar3.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
