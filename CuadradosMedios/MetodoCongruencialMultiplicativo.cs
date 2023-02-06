using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuadradosMedios
{
    public class MetodoCongruencialMultiplicativo
    {
        public List<float> Aleatorios { get; private set; }
        public List<float> Aleatorios2 { get; private set; }

        public int N { get; private set; } //Numero de operaciones a realizar
        public int Semilla { get; private set; } //Valor de la semilla
        public int Constante { get; private set; } //Constante multiplicativa
        public int Modulo { get; private set; } //Modulo
        public bool GeneradosConExito { get; private set; } //RETURN
        public string Error { get; private set; } //RETURN
        public double num2 { get; private set; } //Almacenara al numero
        public MetodoCongruencialMultiplicativo(int semilla, int constante, int modulo, int n)
        {
            Aleatorios = new List<float>();
            Aleatorios2 = new List<float>();//Creacion de la lista donde se almacenaran los numeros
            Semilla = semilla;
            Constante = constante;
            Modulo = modulo;
            N = n;

            for (int i= 1; i<N; i++)
            {
                int antes = Modulo - 1;
                int nuevo = (Semilla / antes);
                Semilla = (Constante * Semilla) % Modulo;
                Aleatorios.Add(float.Parse("0." + Semilla));
                Aleatorios2.Add(float.Parse("0." + nuevo));

            }
        }
    }
}
