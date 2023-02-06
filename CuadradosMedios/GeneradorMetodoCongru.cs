using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuadradosMedios
{
    public class GeneradorMetodoCongru
    {

        public List<float> Aleatorios { get; private set; }
        public int N { get; private set; } //Numero de operaciones a realizar
        public int Semilla { get; private set; } //Valor de la semilla
        public int Constante { get; private set; } //Constante aditiva
        public int Multiplicador { get; private set; } //Multiplicador
        public int Modulo { get; private set; } //Modulo
        public bool GeneradosConExito { get; private set; } //RETURN
        public string Error { get; private set; } //RETURN
        public double num2 { get; private set; } //Almacenara al numero
        public GeneradorMetodoCongru(int semilla, int constante, int modulo, int multiplicador, int n)
        {
            Aleatorios = new List<float>(); //Creacion de la lista donde se almacenaran los numeros
            Semilla = semilla; //x0
            Constante = constante; //c
            Modulo = modulo; //m
            Multiplicador = multiplicador; //a
            N = n;

            for (int i = 1; i < N; i++)
            {
                Semilla = ((Multiplicador * Semilla) + Constante) % Modulo;
                Aleatorios.Add(float.Parse("0." + Semilla));
            }
        }
    }
}
