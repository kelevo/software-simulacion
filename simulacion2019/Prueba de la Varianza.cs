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
    public partial class Prueba_de_la_Varianza : Form
    {
        public Prueba_de_la_Varianza()
        {
            InitializeComponent();
        }

        private void Prueba_de_la_Varianza_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ALGORITMO CUADRADOS MEDIOS ########################################################################
            double semilla, cantidad;
            semilla = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la semilla:", "Semila", "0", 100, 100));
            cantidad = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("¿Cuantos numeros desea generar?:", "Numeros a generar", "0", 100, 100));

            string semillaText = semilla.ToString();
            int posi = semillaText.IndexOf('.');
            semillaText = semillaText.Substring(posi + 1, semillaText.Length - posi - 1);
            semilla = float.Parse(semillaText);

            double semilla_total = 0;

            //string semillaText = semilla.ToString();
            int D = semillaText.Length;

            for (int i = 0; i < cantidad; i++) //GENERA NUMEROS PSEUDOALEATORIOS
            {
                semilla_total = Math.Pow(semilla, 2);
                int l;
                l = semilla_total.ToString().Length;
                semillaText = semilla_total.ToString();
                semillaText = semillaText.Substring((l / 2) - 2, D);

                semilla = double.Parse(semillaText);

                listMostrarCompleto.Items.Add(semilla_total);
                listMostrarCentrales.Items.Add("0." + semilla);

            }

            //------------------------------------------------------------------------------

            double promedio = 0;
            double suma = 0;
            foreach (object item in listMostrarCentrales.Items) //SUMA TODOS LOS NUMEROS ALEATORIOS GENERADOS
            {
                suma += Convert.ToDouble(item);
            }

            promedio = suma / cantidad;

            //-----------------------------------------------------------------------------

            double nuevo = 0;
            double resta = 0;
            foreach (object item in listMostrarCentrales.Items) //SUMA TODOS LOS NUMEROS ALEATORIOS GENERADOS - PROMEDIO 
            {
                resta += Convert.ToDouble(item);                //Y ELEVA AL CUADRAO

                nuevo = Math.Pow((resta - promedio), 2);
            }

            double nuevaSumatoria = nuevo;

            //--------------------------------------------------------------------------------

            txtPromedio.Text = (promedio.ToString());  //IMPRIME EL PROMEDIO

            double ValorEsperado = 0.05; //ES EL VALOR ESPERADO

            double Alfa = ((1 - (ValorEsperado / 2)));  //ELEMENTO NESESARIO PARA LIMITES

            txtAlfa.Text = Alfa.ToString();

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

        private void button4_Click(object sender, EventArgs e)
        {
            //METODO NEUMANN ##############################################################################
            double semilla, cantidad;
            semilla = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la semilla:", "Semila", "0", 100, 100));
            cantidad = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("¿Cuantos numeros desea generar?:", "Numeros a generar", "0", 100, 100));
            double semilla_total = 0;

            string semillaText = semilla.ToString();
            int posi = semillaText.IndexOf('.');
            semillaText = semillaText.Substring(posi + 1, semillaText.Length - posi - 1);
            semilla = float.Parse(semillaText);

            //string semillaText = semilla.ToString();
            int D = semillaText.Length;

            for (int i = 0; i < cantidad; i++) //GENERA NUMEROS PSEUDOALEATORIOS
            {
                semilla_total = Math.Pow(semilla, 2);
                int l;
                l = semilla_total.ToString().Length;
                semillaText = semilla_total.ToString();
                semillaText = semillaText.Substring((l / 2) - 2, 5);

                semilla = double.Parse(semillaText);

                listMostrarCompleto.Items.Add(semilla_total);
                listMostrarCentrales.Items.Add("0." + semilla); 

            }

            //------------------------------------------------------------------------------

            double promedio = 0; 
            double suma = 0;
            foreach (object item in listMostrarCentrales.Items) //SUMA TODOS LOS NUMEROS ALEATORIOS GENERADOS
            {
                suma += Convert.ToDouble(item);
            }

            promedio = suma / cantidad;

            //-----------------------------------------------------------------------------

            double nuevo = 0;
            double resta = 0;
            foreach (object item in listMostrarCentrales.Items) //SUMA TODOS LOS NUMEROS ALEATORIOS GENERADOS - PROMEDIO 
            {
                resta += Convert.ToDouble(item);                //Y ELEVA AL CUADRAO

                nuevo = Math.Pow((resta - promedio), 2); 
            }

            double nuevaSumatoria = nuevo;

            //--------------------------------------------------------------------------------

            txtPromedio.Text = (promedio.ToString());  //IMPRIME EL PROMEDIO

            double ValorEsperado = 0.05; //ES EL VALOR ESPERADO

            double Alfa = ((1 - (ValorEsperado / 2)));  //ELEMENTO NESESARIO PARA LIMITES

            txtAlfa.Text = Alfa.ToString();

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

        private void button2_Click(object sender, EventArgs e)
        {
            //PRODUCTOS MEDIOS ##########################################################################

            double semilla, cantidad, semilla2, semilla_total;

            semilla = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la semilla:", "Semila", "0", 100, 100));
            semilla2 = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la semilla2:", "Semila", "0", 100, 100));
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
                listMostrarCompleto.Items.Add(semilla_total);
                listMostrarCentrales.Items.Add("0." + semilla2);
            }

            //------------------------------------------------------------------------------

            double promedio = 0;
            double suma = 0;
            foreach (object item in listMostrarCentrales.Items) //SUMA TODOS LOS NUMEROS ALEATORIOS GENERADOS
            {
                suma += Convert.ToDouble(item);
            }

            promedio = suma / cantidad;

            //-----------------------------------------------------------------------------

            double nuevo = 0;
            double resta = 0;
            foreach (object item in listMostrarCentrales.Items) //SUMA TODOS LOS NUMEROS ALEATORIOS GENERADOS - PROMEDIO 
            {
                resta += Convert.ToDouble(item);                //Y ELEVA AL CUADRAO

                nuevo = Math.Pow((resta - promedio), 2);
            }

            double nuevaSumatoria = nuevo;

            //--------------------------------------------------------------------------------

            txtPromedio.Text = (promedio.ToString());  //IMPRIME EL PROMEDIO

            double ValorEsperado = 0.05; //ES EL VALOR ESPERADO

            double Alfa = ((1 - (ValorEsperado / 2)));  //ELEMENTO NESESARIO PARA LIMITES

            txtAlfa.Text = Alfa.ToString();

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

        private void button6_Click(object sender, EventArgs e)
        {
            //METODO CONGRUENCIAL ADITIVO ################################################################

            int x1, x2, x3, x4, x5, modo; //Valores iniciales a introducir

            double x6, x7, x8, x9, x10, x11, x12; //Numeros ejemplos que pide

            double r1, r2, r3, r4, r5, r6, r7; //Numeros pseudoaleatorios a generar

                x1 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor inicial 1:", "Semila", "0", 100, 100));
                x2 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor inicial 2:", "Semila", "0", 100, 100));
                x3 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor inicial 3:", "Semila", "0", 100, 100));
                x4 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor inicial 4:", "Semila", "0", 100, 100));
                x5 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor inicial 5:", "Semila", "0", 100, 100));
                modo = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el modo:", "Semila", "0", 100, 100));

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

                listMostrarCentrales.Items.Add("0. " + r1);
                listMostrarCentrales.Items.Add("0. " + r2);
                listMostrarCentrales.Items.Add("0. " + r3);
                listMostrarCentrales.Items.Add("0. " + r4);
                listMostrarCentrales.Items.Add("0. " + r5);
                listMostrarCentrales.Items.Add("0. " + r6);
                listMostrarCentrales.Items.Add("0. " + r7);


            double promedio = 0;
            double suma = r1 + r2 + r3 + r4 + r5 + r6 + r7;

            promedio = suma / 7;

            //-----------------------------------------------------------------------------

            double a = Math.Pow((r1 - promedio), 2);
            double b = Math.Pow((r2 - promedio), 2);
            double c = Math.Pow((r3 - promedio), 2);
            double d = Math.Pow((r4 - promedio), 2);
            double g = Math.Pow((r5 - promedio), 2);
            double f = Math.Pow((r6 - promedio), 2);
            double h = Math.Pow((r7 - promedio), 2);


            double nuevaSumatoria = a + b + c + d + g + f + f; ;

            //--------------------------------------------------------------------------------

            txtPromedio.Text = (promedio.ToString());  //IMPRIME EL PROMEDIO

            double ValorEsperado = 0.05; //ES EL VALOR ESPERADO

            double Alfa = ((1 - (ValorEsperado / 2)));  //ELEMENTO NESESARIO PARA LIMITES

            txtAlfa.Text = Alfa.ToString();

            double Z = 0.95996398;

            txtZ.Text = (Z.ToString());

            double LimSuperior = ((ValorEsperado - Z) * (1 / Math.Sqrt(12 * 7)));

            txtLimSuperior.Text = (LimSuperior.ToString());

            double LimInferior = ((ValorEsperado + Z) * (1 / Math.Sqrt(12 * 7)));

            txtLimInferior.Text = (LimInferior.ToString());

            //--------------------------------------------------------------------------------------

            //FORMULA DE LA VARIANZA

            double varianza = (nuevaSumatoria / 7 - 1);

            txtVarianza.Text = (varianza.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ALGORITMO PRODUCTO MEDIO ########################################################################
            double semilla, cantidad, k;
            semilla = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la semilla:", "Semila", "0", 100, 100));
            k = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor de K:", "Semila", "0", 100, 100));
            cantidad = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("¿Cuantos numeros desea generar?:", "Numeros a generar", "0", 100, 100));

            double semilla_total = 0;

            string semillaText = semilla.ToString();
            

            //string semillaText = semilla.ToString();
            int posi = semillaText.IndexOf('.');
            semillaText = semillaText.Substring(posi + 1, semillaText.Length - posi - 1);
            semilla = float.Parse(semillaText);

            int D = semillaText.Length;

            for (int i = 0; i < cantidad; i++) //GENERA NUMEROS PSEUDOALEATORIOS
            {
                semilla_total = semilla * k;
                int l;
                l = semilla_total.ToString().Length;
                semillaText = semilla_total.ToString();
                semillaText = semillaText.Substring((l / 2) - 1, D);  //ERROR ====================================="""""

                semilla = double.Parse(semillaText);

                listMostrarCompleto.Items.Add(semilla_total);
                listMostrarCentrales.Items.Add("0." + semilla);

            }

            //------------------------------------------------------------------------------

            double promedio = 0;
            double suma = 0;
            foreach (object item in listMostrarCentrales.Items) //SUMA TODOS LOS NUMEROS ALEATORIOS GENERADOS
            {
                suma += Convert.ToDouble(item);
            }

            promedio = suma / cantidad;

            //-----------------------------------------------------------------------------

            double nuevo = 0;
            double resta = 0;
            foreach (object item in listMostrarCentrales.Items) //SUMA TODOS LOS NUMEROS ALEATORIOS GENERADOS - PROMEDIO 
            {
                resta += Convert.ToDouble(item);                //Y ELEVA AL CUADRAO

                nuevo = Math.Pow((resta - promedio), 2);
            }

            double nuevaSumatoria = nuevo;

            //--------------------------------------------------------------------------------

            txtPromedio.Text = (promedio.ToString());  //IMPRIME EL PROMEDIO

            double ValorEsperado = 0.05; //ES EL VALOR ESPERADO

            double Alfa = ((1 - (ValorEsperado / 2)));  //ELEMENTO NESESARIO PARA LIMITES

            txtAlfa.Text = Alfa.ToString();

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

        private void button5_Click(object sender, EventArgs e)
        {
            //METODO CONGRUENCIAL ######################################################################

            double N;                //Numero de operaciones a realizar
            double Semilla;       //Valor de la semilla
            double Constante;     //Constante aditiva
            double Multiplicador; //Multiplicador
            double Modulo;        //Modulo

            Constante = 0; //c
            Modulo = 0; //m
            Multiplicador = 0; //a
            N = 0;

            Semilla = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la semilla:", "Semila", "0", 100, 100));
            Constante = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor de la constante:", "Semila", "0", 100, 100));
            Multiplicador = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor de multiplicador:", "Semila", "0", 100, 100));
            Modulo = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor del modulo:", "Semila", "0", 100, 100));
            N = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("¿Cuantos numeros desea generar?:", "Numeros a generar", "0", 100, 100));

            for (int i = 1; i < N; i++)
            {
                Semilla = ((Multiplicador * Semilla) + Constante) % Modulo;
                listMostrarCentrales.Items.Add(float.Parse("0." + Semilla));
            }

            //------------------------------------------------------------------------------

            double promedio = 0;
            double suma = 0;
            foreach (object item in listMostrarCentrales.Items) //SUMA TODOS LOS NUMEROS ALEATORIOS GENERADOS
            {
                suma += Convert.ToDouble(item);
            }

            promedio = suma / N;

            //-----------------------------------------------------------------------------

            double nuevo = 0;
            double resta = 0;
            foreach (object item in listMostrarCentrales.Items) //SUMA TODOS LOS NUMEROS ALEATORIOS GENERADOS - PROMEDIO 
            {
                resta += Convert.ToDouble(item);                //Y ELEVA AL CUADRAO

                nuevo = Math.Pow((resta - promedio), 2);
            }

            double nuevaSumatoria = nuevo;

            //--------------------------------------------------------------------------------

            txtPromedio.Text = (promedio.ToString());  //IMPRIME EL PROMEDIO

            double ValorEsperado = 0.05; //ES EL VALOR ESPERADO

            double Alfa = ((1 - (ValorEsperado / 2)));  //ELEMENTO NESESARIO PARA LIMITES

            txtAlfa.Text = Alfa.ToString();

            double Z = 0.95996398;

            txtZ.Text = (Z.ToString());

            double LimSuperior = ((ValorEsperado - Z) * (1 / Math.Sqrt(12 * N)));

            txtLimSuperior.Text = (LimSuperior.ToString());

            double LimInferior = ((ValorEsperado + Z) * (1 / Math.Sqrt(12 * N)));

            txtLimInferior.Text = (LimInferior.ToString());

            //--------------------------------------------------------------------------------------

            //FORMULA DE LA VARIANZA

            double varianza = (nuevo / N - 1);

            txtVarianza.Text = (varianza.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //METODO CONGRUENCIAL MULTIPLICATIVO

            double Semilla, k, Modulo, N, g, a;

            Semilla = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la semilla:", "Semila", "0", 100, 100));
            k = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor de k:", "Semila", "0", 100, 100));
            g = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor de g:", "Semila", "0", 100, 100));
            Modulo = Math.Pow(2, g);
            N = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("¿Cuantos numeros desea generar?:", "Numeros a generar", "0", 100, 100));

            a = (5 + (8 * k));

            //txtModuloCongMulti.Text = (Modulo.ToString());

            for (int i = 1; i < N; i++)
            {

                Semilla = (a * Semilla) % Modulo;
                listMostrarCompleto.Items.Add(Semilla);
                double nuevo2 = (Semilla / (Modulo - 1));

                string semillaText = Semilla.ToString();

                int tamanotexto = nuevo2.ToString().Length;

                semillaText = semillaText.Substring(0, 4);

                listMostrarCentrales.Items.Add("0." + nuevo2);

            }

            //------------------------------------------------------------------------------

            double promedio = 0;
            double suma = 0;
            foreach (object item in listMostrarCentrales.Items) //SUMA TODOS LOS NUMEROS ALEATORIOS GENERADOS
            {
                suma += Convert.ToDouble(item);
            }

            promedio = suma / N;

            //-----------------------------------------------------------------------------

            double nuevo = 0;
            double resta = 0;
            foreach (object item in listMostrarCentrales.Items) //SUMA TODOS LOS NUMEROS ALEATORIOS GENERADOS - PROMEDIO 
            {
                resta += Convert.ToDouble(item);                //Y ELEVA AL CUADRAO

                nuevo = Math.Pow((resta - promedio), 2);
            }

            double nuevaSumatoria = nuevo;

            //--------------------------------------------------------------------------------

            txtPromedio.Text = (promedio.ToString());  //IMPRIME EL PROMEDIO

            double ValorEsperado = 0.05; //ES EL VALOR ESPERADO

            double Alfa = ((1 - (ValorEsperado / 2)));  //ELEMENTO NESESARIO PARA LIMITES

            txtAlfa.Text = Alfa.ToString();

            double Z = 0.95996398;

            txtZ.Text = (Z.ToString());

            double LimSuperior = ((ValorEsperado - Z) * (1 / Math.Sqrt(12 * N)));

            txtLimSuperior.Text = (LimSuperior.ToString());

            double LimInferior = ((ValorEsperado + Z) * (1 / Math.Sqrt(12 * N)));

            txtLimInferior.Text = (LimInferior.ToString());

            //--------------------------------------------------------------------------------------

            //FORMULA DE LA VARIANZA

            double varianza = (nuevo / N - 1);

            txtVarianza.Text = (varianza.ToString());
        }
    }
}
