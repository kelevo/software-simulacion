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
    public partial class montecarlo : Form
    {
        public montecarlo()
        {
            InitializeComponent();
        }

        private void btnCuadradosMedios_Click(object sender, EventArgs e)
        {
            //ALGORITMO CUADRADOS MEDIOS ########################################################################

            //Declaracion de variables
            double semilla, cantidad, numintervalos;

            //Introduccion de datos
            numintervalos = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("¿Cuantos intervalos desea?:", "Dados", "0", 100, 100));
            semilla = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la semilla:", "Semila", "0", 100, 100));
            cantidad = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("¿Cuantos numeros desea generar?:", "Numeros a generar", "0", 100, 100));

            //Creacion de intervalos

            //Gneracion de numeros pseudoaleatorios ----------------------------------
            string semillaText = semilla.ToString();
            int posi = semillaText.IndexOf('.');
            semillaText = semillaText.Substring(posi + 1, semillaText.Length - posi - 1);
            semilla = float.Parse(semillaText);

            double semilla_total = 0;
            int D = semillaText.Length;
            double valorintervalo = (1 / numintervalos);

            for (int i = 0; i < cantidad; i++)
            {
                semilla_total = Math.Pow(semilla, 2);
                int l;
                l = semilla_total.ToString().Length;
                semillaText = semilla_total.ToString();
                semillaText = semillaText.Substring((l / 2) - 2, D);

                semilla = double.Parse(semillaText);

                listNumGene.Items.Add("0." + semilla);

            }

            foreach (object item in listNumGene.Items)
            {

                //Asignacion de valores a intervalos

                if (Convert.ToDouble(item) < valorintervalo)
                {
                    listInter1.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 2) && Convert.ToDouble(item) > valorintervalo)
                {
                    listInter2.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 3) && Convert.ToDouble(item) > (valorintervalo * 2))
                {
                    listInter3.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 4) && Convert.ToDouble(item) > (valorintervalo * 3))
                {
                    listInter4.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 5) && Convert.ToDouble(item) > (valorintervalo * 4))
                {
                    listInter5.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 6) && Convert.ToDouble(item) > (valorintervalo * 5))
                {
                    listInter6.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 7) && Convert.ToDouble(item) > (valorintervalo * 6))
                {
                    listInter7.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 8) && Convert.ToDouble(item) > (valorintervalo * 7))
                {
                    listInter8.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 9) && Convert.ToDouble(item) > (valorintervalo * 8))
                {
                    listInter9.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 10) && Convert.ToDouble(item) > (valorintervalo * 9))
                {
                    listInter10.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 11) && Convert.ToDouble(item) > (valorintervalo * 10))
                {
                    listInter11.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 12) && Convert.ToDouble(item) > (valorintervalo * 13))
                {
                    listInter12.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 14) && Convert.ToDouble(item) > (valorintervalo * 15))
                {
                    listInter13.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 15) && Convert.ToDouble(item) > (valorintervalo * 16))
                {
                    listInter14.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 16) && Convert.ToDouble(item) > (valorintervalo * 17))
                {
                    listInter15.Items.Add(Convert.ToDouble(item));
                }

            }
        }

        private void btnProductosMedios_Click(object sender, EventArgs e)
        {
            //PRODUCTOS MEDIOS #####################################################################

            double semilla, cantidad, semilla2, semilla_total, numintervalos;

            numintervalos = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("¿Cuantos intervalos desea?:", "Dados", "0", 100, 100));
            semilla = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la semilla:", "Semila", "0", 100, 100));
            semilla2 = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la semilla2:", "Semila", "0", 100, 100));
            cantidad = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("¿Cuantos numeros desea generar?:", "Numeros a generar", "0", 100, 100));

            double valorintervalo = (1 / numintervalos);

            for (int i = 0; i < cantidad; i++)
            {
                semilla_total = semilla * semilla2;
                string Nsemilla_total;
                Nsemilla_total = Convert.ToString(semilla_total);
                String D4;
                D4 = Nsemilla_total.Substring(2, 4);
                semilla2 = Convert.ToInt32(D4);
                listNumGene.Items.Add("0." + semilla2);
            }

            foreach (object item in listNumGene.Items)
            {

                //Asignacion de valores a intervalos

                if (Convert.ToDouble(item) < valorintervalo)
                {
                    listInter1.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 2) && Convert.ToDouble(item) > valorintervalo)
                {
                    listInter2.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 3) && Convert.ToDouble(item) > (valorintervalo * 2))
                {
                    listInter3.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 4) && Convert.ToDouble(item) > (valorintervalo * 3))
                {
                    listInter4.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 5) && Convert.ToDouble(item) > (valorintervalo * 4))
                {
                    listInter5.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 6) && Convert.ToDouble(item) > (valorintervalo * 5))
                {
                    listInter6.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 7) && Convert.ToDouble(item) > (valorintervalo * 6))
                {
                    listInter7.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 8) && Convert.ToDouble(item) > (valorintervalo * 7))
                {
                    listInter8.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 9) && Convert.ToDouble(item) > (valorintervalo * 8))
                {
                    listInter9.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 10) && Convert.ToDouble(item) > (valorintervalo * 9))
                {
                    listInter10.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 11) && Convert.ToDouble(item) > (valorintervalo * 10))
                {
                    listInter11.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 12) && Convert.ToDouble(item) > (valorintervalo * 13))
                {
                    listInter12.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 14) && Convert.ToDouble(item) > (valorintervalo * 15))
                {
                    listInter13.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 15) && Convert.ToDouble(item) > (valorintervalo * 16))
                {
                    listInter14.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 16) && Convert.ToDouble(item) > (valorintervalo * 17))
                {
                    listInter15.Items.Add(Convert.ToDouble(item));
                }
            }
        }

        private void btnProductoMedioModificado_Click(object sender, EventArgs e)
        {

            //PRODUCTO MEDIO MODIFICADO ############################################################3

            double semilla, cantidad, k, numintervalos;
            numintervalos = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("¿Cuantos intervalos desea?:", "Dados", "0", 100, 100));
            semilla = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la semilla:", "Semila", "0", 100, 100));
            k = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor de K:", "Semila", "0", 100, 100));
            cantidad = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("¿Cuantos numeros desea generar?:", "Numeros a generar", "0", 100, 100));

            double semilla_total = 0;
            string semillaText = semilla.ToString();

            int posi = semillaText.IndexOf('.');
            semillaText = semillaText.Substring(posi + 1, semillaText.Length - posi - 1);
            semilla = float.Parse(semillaText);

            int D = semillaText.Length;
            double valorintervalo = (1 / numintervalos);

            for (int i = 0; i < cantidad; i++)
            {
                semilla_total = semilla * k;
                int l;
                l = semilla_total.ToString().Length;
                semillaText = semilla_total.ToString();
                semillaText = semillaText.Substring((l / 2) - 1, D);  //ERROR ====================================="""""

                semilla = double.Parse(semillaText);

                listNumGene.Items.Add("0." + semilla);

            }

            foreach (object item in listNumGene.Items)
            {

                //Asignacion de valores a intervalos

                if (Convert.ToDouble(item) < valorintervalo)
                {
                    listInter1.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 2) && Convert.ToDouble(item) > valorintervalo)
                {
                    listInter2.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 3) && Convert.ToDouble(item) > (valorintervalo * 2))
                {
                    listInter3.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 4) && Convert.ToDouble(item) > (valorintervalo * 3))
                {
                    listInter4.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 5) && Convert.ToDouble(item) > (valorintervalo * 4))
                {
                    listInter5.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 6) && Convert.ToDouble(item) > (valorintervalo * 5))
                {
                    listInter6.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 7) && Convert.ToDouble(item) > (valorintervalo * 6))
                {
                    listInter7.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 8) && Convert.ToDouble(item) > (valorintervalo * 7))
                {
                    listInter8.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 9) && Convert.ToDouble(item) > (valorintervalo * 8))
                {
                    listInter9.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 10) && Convert.ToDouble(item) > (valorintervalo * 9))
                {
                    listInter10.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 11) && Convert.ToDouble(item) > (valorintervalo * 10))
                {
                    listInter11.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 12) && Convert.ToDouble(item) > (valorintervalo * 13))
                {
                    listInter12.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 14) && Convert.ToDouble(item) > (valorintervalo * 15))
                {
                    listInter13.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 15) && Convert.ToDouble(item) > (valorintervalo * 16))
                {
                    listInter14.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 16) && Convert.ToDouble(item) > (valorintervalo * 17))
                {
                    listInter15.Items.Add(Convert.ToDouble(item));
                }
            }
        }

        private void btnNeumann_Click(object sender, EventArgs e)
        {
            //METODO NEUMANN ##############################################################################

            double semilla, cantidad, numintervalos;
            numintervalos = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("¿Cuantos intervalos desea?:", "Dados", "0", 100, 100));
            semilla = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la semilla:", "Semila", "0", 100, 100));
            cantidad = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("¿Cuantos numeros desea generar?:", "Numeros a generar", "0", 100, 100));
            double semilla_total = 0;

            string semillaText = semilla.ToString();
            int posi = semillaText.IndexOf('.');
            semillaText = semillaText.Substring(posi + 1, semillaText.Length - posi - 1);
            semilla = float.Parse(semillaText);

            int D = semillaText.Length;
            double valorintervalo = (1 / numintervalos);

            for (int i = 0; i < cantidad; i++)
            {
                semilla_total = Math.Pow(semilla, 2);
                int l;
                l = semilla_total.ToString().Length;
                semillaText = semilla_total.ToString();
                semillaText = semillaText.Substring((l / 2) - 2, 5);

                semilla = double.Parse(semillaText);

                listNumGene.Items.Add("0." + semilla);

            }


            foreach (object item in listNumGene.Items)
            {

                //Asignacion de valores a intervalos

                if (Convert.ToDouble(item) < valorintervalo)
                {
                    listInter1.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 2) && Convert.ToDouble(item) > valorintervalo)
                {
                    listInter2.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 3) && Convert.ToDouble(item) > (valorintervalo * 2))
                {
                    listInter3.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 4) && Convert.ToDouble(item) > (valorintervalo * 3))
                {
                    listInter4.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 5) && Convert.ToDouble(item) > (valorintervalo * 4))
                {
                    listInter5.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 6) && Convert.ToDouble(item) > (valorintervalo * 5))
                {
                    listInter6.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 7) && Convert.ToDouble(item) > (valorintervalo * 6))
                {
                    listInter7.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 8) && Convert.ToDouble(item) > (valorintervalo * 7))
                {
                    listInter8.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 9) && Convert.ToDouble(item) > (valorintervalo * 8))
                {
                    listInter9.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 10) && Convert.ToDouble(item) > (valorintervalo * 9))
                {
                    listInter10.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 11) && Convert.ToDouble(item) > (valorintervalo * 10))
                {
                    listInter11.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 12) && Convert.ToDouble(item) > (valorintervalo * 13))
                {
                    listInter12.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 14) && Convert.ToDouble(item) > (valorintervalo * 15))
                {
                    listInter13.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 15) && Convert.ToDouble(item) > (valorintervalo * 16))
                {
                    listInter14.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 16) && Convert.ToDouble(item) > (valorintervalo * 17))
                {
                    listInter15.Items.Add(Convert.ToDouble(item));
                }
            }
        }

        private void btnCongruencial_Click(object sender, EventArgs e)
        {
            //METODO CONGRUENCIAL ######################################################################

            double numintervalos;
            double N;             //Numero de operaciones a realizar
            double Semilla;       //Valor de la semilla
            double Constante;     //Constante aditiva
            double Multiplicador; //Multiplicador
            double Modulo;        //Modulo

            Constante = 0; //c
            Modulo = 0; //m
            Multiplicador = 0; //a
            N = 0;

            numintervalos = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("¿Cuantos intervalos desea?:", "Dados", "0", 100, 100));
            Semilla = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la semilla:", "Semila", "0", 100, 100));
            Constante = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor de la constante:", "Semila", "0", 100, 100));
            Multiplicador = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor de multiplicador:", "Semila", "0", 100, 100));
            Modulo = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor del modulo:", "Semila", "0", 100, 100));
            N = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("¿Cuantos numeros desea generar?:", "Numeros a generar", "0", 100, 100));

            double valorintervalo = (1 / numintervalos);
            for (int i = 1; i < N; i++)
            {
                Semilla = ((Multiplicador * Semilla) + Constante) % Modulo;
                listNumGene.Items.Add(float.Parse("0." + Semilla));
            }

            foreach (object item in listNumGene.Items)
            {

                //Asignacion de valores a intervalos

                if (Convert.ToDouble(item) < valorintervalo)
                {
                    listInter1.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 2) && Convert.ToDouble(item) > valorintervalo)
                {
                    listInter2.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 3) && Convert.ToDouble(item) > (valorintervalo * 2))
                {
                    listInter3.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 4) && Convert.ToDouble(item) > (valorintervalo * 3))
                {
                    listInter4.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 5) && Convert.ToDouble(item) > (valorintervalo * 4))
                {
                    listInter5.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 6) && Convert.ToDouble(item) > (valorintervalo * 5))
                {
                    listInter6.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 7) && Convert.ToDouble(item) > (valorintervalo * 6))
                {
                    listInter7.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 8) && Convert.ToDouble(item) > (valorintervalo * 7))
                {
                    listInter8.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 9) && Convert.ToDouble(item) > (valorintervalo * 8))
                {
                    listInter9.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 10) && Convert.ToDouble(item) > (valorintervalo * 9))
                {
                    listInter10.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 11) && Convert.ToDouble(item) > (valorintervalo * 10))
                {
                    listInter11.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 12) && Convert.ToDouble(item) > (valorintervalo * 13))
                {
                    listInter12.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 14) && Convert.ToDouble(item) > (valorintervalo * 15))
                {
                    listInter13.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 15) && Convert.ToDouble(item) > (valorintervalo * 16))
                {
                    listInter14.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 16) && Convert.ToDouble(item) > (valorintervalo * 17))
                {
                    listInter15.Items.Add(Convert.ToDouble(item));
                }
            }
        }

        private void btnCongruencialAditivo_Click(object sender, EventArgs e)
        {
            //METODO CONGRUENCIAL ADITIVO ################################################################

            double numintervalos;
            int x1, x2, x3, x4, x5, modo; //Valores iniciales a introducir
            double x6, x7, x8, x9, x10, x11, x12; //Numeros ejemplos que pide
            double r1, r2, r3, r4, r5, r6, r7; //Numeros pseudoaleatorios a generar

            numintervalos = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("¿Cuantos intervalos desea?:", "Dados", "0", 100, 100));
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

            double valorintervalo = (1 / numintervalos);

            listNumGene.Items.Add("0. " + r1);
            listNumGene.Items.Add("0. " + r2);
            listNumGene.Items.Add("0. " + r3);
            listNumGene.Items.Add("0. " + r4);
            listNumGene.Items.Add("0. " + r5);
            listNumGene.Items.Add("0. " + r6);
            listNumGene.Items.Add("0. " + r7);

            foreach (object item in listNumGene.Items)
            {

                //Asignacion de valores a intervalos

                if (Convert.ToDouble(item) < valorintervalo)
                {
                    listInter1.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 2) && Convert.ToDouble(item) > valorintervalo)
                {
                    listInter2.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 3) && Convert.ToDouble(item) > (valorintervalo * 2))
                {
                    listInter3.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 4) && Convert.ToDouble(item) > (valorintervalo * 3))
                {
                    listInter4.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 5) && Convert.ToDouble(item) > (valorintervalo * 4))
                {
                    listInter5.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 6) && Convert.ToDouble(item) > (valorintervalo * 5))
                {
                    listInter6.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 7) && Convert.ToDouble(item) > (valorintervalo * 6))
                {
                    listInter7.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 8) && Convert.ToDouble(item) > (valorintervalo * 7))
                {
                    listInter8.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 9) && Convert.ToDouble(item) > (valorintervalo * 8))
                {
                    listInter9.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 10) && Convert.ToDouble(item) > (valorintervalo * 9))
                {
                    listInter10.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 11) && Convert.ToDouble(item) > (valorintervalo * 10))
                {
                    listInter11.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 12) && Convert.ToDouble(item) > (valorintervalo * 13))
                {
                    listInter12.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 14) && Convert.ToDouble(item) > (valorintervalo * 15))
                {
                    listInter13.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 15) && Convert.ToDouble(item) > (valorintervalo * 16))
                {
                    listInter14.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 16) && Convert.ToDouble(item) > (valorintervalo * 17))
                {
                    listInter15.Items.Add(Convert.ToDouble(item));
                }

            }
        }

        private void btnCongruencialMultiplicativo_Click(object sender, EventArgs e)
        {
            //METODO CONGRUENCIAL MULTIPLICATIVO

            double Semilla, k, Modulo, N, g, a, numintervalos;

            numintervalos = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("¿Cuantos intervalos desea?:", "Dados", "0", 100, 100));
            Semilla = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la semilla:", "Semila", "0", 100, 100));
            k = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor de k:", "Semila", "0", 100, 100));
            g = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor de g:", "Semila", "0", 100, 100));
            Modulo = Math.Pow(2, g);
            N = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("¿Cuantos numeros desea generar?:", "Numeros a generar", "0", 100, 100));

            a = (5 + (8 * k));

            double valorintervalo = (1 / numintervalos);

            for (int i = 1; i < N; i++)
            {

                Semilla = (a * Semilla) % Modulo;
                double nuevo2 = (Semilla / (Modulo - 1));
                string semillaText = Semilla.ToString();
                int tamanotexto = nuevo2.ToString().Length;
                semillaText = semillaText.Substring(0, 4);
                listNumGene.Items.Add("0." + nuevo2);

            }

            foreach (object item in listNumGene.Items)
            {

                //Asignacion de valores a intervalos

                if (Convert.ToDouble(item) < valorintervalo)
                {
                    listInter1.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 2) && Convert.ToDouble(item) > valorintervalo)
                {
                    listInter2.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 3) && Convert.ToDouble(item) > (valorintervalo * 2))
                {
                    listInter3.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 4) && Convert.ToDouble(item) > (valorintervalo * 3))
                {
                    listInter4.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 5) && Convert.ToDouble(item) > (valorintervalo * 4))
                {
                    listInter5.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 6) && Convert.ToDouble(item) > (valorintervalo * 5))
                {
                    listInter6.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 7) && Convert.ToDouble(item) > (valorintervalo * 6))
                {
                    listInter7.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 8) && Convert.ToDouble(item) > (valorintervalo * 7))
                {
                    listInter8.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 9) && Convert.ToDouble(item) > (valorintervalo * 8))
                {
                    listInter9.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 10) && Convert.ToDouble(item) > (valorintervalo * 9))
                {
                    listInter10.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 11) && Convert.ToDouble(item) > (valorintervalo * 10))
                {
                    listInter11.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 12) && Convert.ToDouble(item) > (valorintervalo * 13))
                {
                    listInter12.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 14) && Convert.ToDouble(item) > (valorintervalo * 15))
                {
                    listInter13.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 15) && Convert.ToDouble(item) > (valorintervalo * 16))
                {
                    listInter14.Items.Add(Convert.ToDouble(item));
                }
                else if (Convert.ToDouble(item) < (valorintervalo * 16) && Convert.ToDouble(item) > (valorintervalo * 17))
                {
                    listInter15.Items.Add(Convert.ToDouble(item));
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listInter1.Items.Clear();
            listInter2.Items.Clear();
            listInter3.Items.Clear();
            listInter4.Items.Clear();
            listInter5.Items.Clear();
            listInter6.Items.Clear();
            listInter7.Items.Clear();
            listInter8.Items.Clear();
            listInter9.Items.Clear();
            listInter10.Items.Clear();
            listInter11.Items.Clear();
            listInter12.Items.Clear();
            listInter13.Items.Clear();
            listInter14.Items.Clear();
            listInter15.Items.Clear();
            listNumGene.Items.Clear();
        }
    }
}
