using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuadradosMedios
{
    public class Generador
    {

        public List<float> Aleatorios { get; private set; }
        public int N { get; private set; }
        public float Semilla { get; private set; }
        public int D { get; private set; }
        public bool GeneradosConExito { get; private set; }
        public string Error { get; private set; }
        public Generador(float semilla, int n)
        {
            Aleatorios = new List<float>();
            Semilla = semilla;
            //La semilla tiene que ser similara a 0.1111

                string semillaText = semilla.ToString();
                int posi = semillaText.IndexOf('.');
                semillaText = semillaText.Substring(posi + 1, semillaText.Length - posi - 1);
                D = semillaText.Length;
                Semilla = float.Parse(semillaText);
                N = n;

                if (D > 3)
                {
                    float x0;
                    x0 = Semilla;
                    String temp;
                    int longitud;

                    for (int i = 0; i < N; i++)
                    {
                        //x1=54316900
                        if (x0 == 0)
                        {
                            break;
                        }

                        temp = Math.Pow(x0, 2).ToString();
                        longitud = temp.Length;

                        //longitud=8
                        if (longitud % 2 == 1)
                        {
                            temp = "0" + temp;
                            longitud = temp.Length;
                        }

                        //temp="3169"
                        temp = temp.Substring((longitud / 2) - 2, D);
                        Aleatorios.Add(float.Parse("0."+temp));
                        x0 = float.Parse(temp);
                    }

                    GeneradosConExito = true;
                    Error = "";
                }

                else
                {
                    GeneradosConExito = false;
                    Error = "D no es mayor a 3";
                }
            }
    }
}


