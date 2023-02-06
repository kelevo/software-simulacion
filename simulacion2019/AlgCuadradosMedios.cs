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
    public partial class AlgCuadradosMedios : Form
    {
        public AlgCuadradosMedios()
        {
            InitializeComponent();
        }

        private void BtnGenerarCuadradosMedios_Click(object sender, EventArgs e)
        {
            Generador gen = new Generador(float.Parse(txtIngreseSemilla.Text), int.Parse(txtNumerosGenerar.Text));

            if (gen.GeneradosConExito)
            {

                double valor;
                valor = int.Parse(txtNumerosGenerar.Text);

                ProcesaAleatorios procesador = new ProcesaAleatorios();

                textBoxmostrar.Text =  (procesador.CreaTexto(gen.Aleatorios) + Environment.NewLine);
                MessageBox.Show("PROCESO TERMINADO CON EXITO", "FELICIDADES", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show(gen.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            textBoxmostrar.Clear();
            txtIngreseSemilla.Clear();
            txtNumerosGenerar.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
