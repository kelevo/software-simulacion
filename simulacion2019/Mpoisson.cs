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
    public partial class Mpoisson : Form
    {
        public Mpoisson()
        {
            InitializeComponent();
        }

        private void btnProductosMedios_Click(object sender, EventArgs e)
        {
            //PRODUCTOS MEDIOS ##########################################################################

            double semilla, cantidad, semilla2, semilla_total, x;

            semilla = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la semilla:", "Semila", "0", 100, 100));
            semilla2 = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la semilla2:", "Semila", "0", 100, 100));
            x = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor de X:", "X", "0", 100, 100));
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

            //Factorial de X

            double factx = 1;

            for (int i = 1; i <= x; i++)
            {
                factx = factx * i;
            }

            txtFactorial.Text = factx.ToString();

            //------------------------------------------------------------------------------------

            double promedio = 0;
            double suma = 0;
            foreach (object item in listNumCentrales.Items) //SUMA TODOS LOS NUMEROS ALEATORIOS GENERADOS
            {
                suma += Convert.ToDouble(item);
            }

            promedio = suma / cantidad;

            double euler = 2.7182;
            double valorx = 0;

            valorx = (((Math.Pow(euler, -promedio) * (Math.Pow(promedio, x))))/(factx));

            txtX.Text = valorx.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listNumCentrales.Items.Clear();
            listNumGene.Items.Clear();
            txtX.Clear();
            txtFactorial.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
