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
    public partial class Mexponencial : Form
    {
        public Mexponencial()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnProductosMedios_Click(object sender, EventArgs e)
        {
            //PRODUCTOS MEDIOS ##########################################################################

            double semilla, cantidad, semilla2, semilla_total, lambda;

            semilla = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la semilla:", "Semila", "0", 100, 100));
            semilla2 = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la semilla2:", "Semila", "0", 100, 100));
            lambda = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor de Lambda:", "Lambda", "0", 100, 100));
            cantidad = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("¿Cuantos numeros desea generar?:", "Numeros a generar", "0", 100, 100));

            //semilla_total = 0;

            for (int i = 0; i < cantidad; i++)
            {
                semilla_total = semilla * semilla2;
                string Nsemilla_total;
                Nsemilla_total = Convert.ToString(semilla_total);
                String D4;
                D4 = Nsemilla_total.Substring(2, 4);
                semilla2 = Convert.ToInt32(D4);
                listNumGene.Items.Add(semilla_total);
                listNumCentrales.Items.Add("0." + semilla2);
            }

            //------------------------------------------------------------------------------


            double fraccion = 1 / lambda;
            double variableA = 0;
            foreach (object item in listNumCentrales.Items) //SUMA TODOS LOS NUMEROS ALEATORIOS GENERADOS
            {
                variableA = (fraccion * (Math.Log(Convert.ToDouble(item))));
                listVariables.Items.Add(variableA);
            }

            //-----------------------------------------------------------------------------

            
            double promedio = 0;
            double suma = 0;
            foreach (object item in listVariables.Items) //SUMA TODOS LOS NUMEROS ALEATORIOS GENERADOS
            {
                suma += Convert.ToDouble(item);
            }

            promedio = suma / cantidad;

            //-----------------------------------------------------------------------------

            double nuevo = 0;
            double resta = 0;
            foreach (object item in listVariables.Items) //SUMA TODOS LOS NUMEROS ALEATORIOS GENERADOS - PROMEDIO 
            {
                resta += Convert.ToDouble(item);                //Y ELEVA AL CUADRAO

                nuevo = Math.Pow((resta - promedio), 2);
            }

            double nuevaSumatoria = nuevo;

            //--------------------------------------------------------------------------------

            txtPromedio.Text = (promedio.ToString());  //IMPRIME EL PROMEDIO

            double ValorEsperado = 0.05; //ES EL VALOR ESPERADO

            double Alfa = ((1 - (ValorEsperado / 2)));  //ELEMENTO NESESARIO PARA LIMITES

            double Z = 0.95996398;

            txtZ.Text = (Z.ToString());

            double LimSuperior = ((ValorEsperado - Z) * (1 / Math.Sqrt(12 * cantidad)));

            txtLimSuperior.Text = (LimSuperior.ToString());

            double LimInferior = ((ValorEsperado + Z) * (1 / Math.Sqrt(12 * cantidad)));

            txtLimInferior.Text = (LimInferior.ToString());

            //--------------------------------------------------------------------------------------

            //FORMULA DE LA VARIANZA

            double varianza = (nuevo / cantidad - 1);

            txtVarianza.Text = (varianza.ToString());
        }
   

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listNumCentrales.Items.Clear();
            listNumGene.Items.Clear();
            listVariables.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mexponencial_Load(object sender, EventArgs e)
        {

        }

        private void btnVarianza_Click(object sender, EventArgs e)
        {

        }
    }
}
