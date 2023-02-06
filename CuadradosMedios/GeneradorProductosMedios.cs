using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuadradosMedios
{
    public class GeneradorProductosMedios
    {

        public List<float> PseudoAleatorios { get; private set; }
        public int N { get; private set; } //Numero de operaciones a realizar
        public float Semilla { get; private set; } //Primer valor
        public float Semilla2 { get; private set; } //Segundo valor
        public int D { get; private set; } //Numero de digitios de SEMILLA convertida a STRING
        public int E { get; private set; } //Numero de digitios de SEMILLA2 convertida a STRING
        public bool GeneradosConExito { get; private set; } //RETURN
        public string Error { get; private set; } //RETURN
        public GeneradorProductosMedios(float semilla, float semilla2, int n) //CLASE a llamar para GENERAR
        {
            PseudoAleatorios = new List<float>(); //Creacion de la lista donde se almacenaran los numeros
            Semilla = semilla;
            Semilla2 = semilla2;

            //La semilla tiene que ser similar a 1111

            string semillaText = semilla.ToString();
            string semilla2Text = semilla2.ToString();

            D = semillaText.Length;
            E = semilla2Text.Length;

            Semilla = float.Parse(semillaText);
            Semilla2 = float.Parse(semilla2Text); 
            N = n;

            //GENERACION DE NUMEROS
            
            if (D > 3 & E > 3) 
                {
                    float x0;
                    float x1;
                    x0 = Semilla;
                    x1 = Semilla2;
                    String temp;
                    int longitud;

                    for (int i = 0; i < N; i++)
                    {
                        //NUESTRA SEMILLA TENDRA 8 DIGITOS EJEMPLO (x0=54316900)

                        if (x0 == 0 & x1 == 0) //Si X0 y X1 son iguales a 0 se salta el bucle for
                        {
                            break;
                        }

                  
                    temp = (x0 * x1).ToString(); //Convirtio a cadena de texto (temp=28756010)
                    longitud = temp.Length; //Otorga valor de longitud (longitud  =7)
                    

                        if (longitud % 2 == 1) //En caso de que falte un digito para que sean 8 se agrega 0
                        {
                            temp = "0" + temp; //Se agrega el 0 (028756010)
                            longitud = temp.Length;
                        }      

                    //NUESTRA SEMILLA SE REDUCE A 4 DIGITOS EJEMPLO (x0=3169)
                    
                    temp = temp.Substring((longitud / 2) - 2, D);
                    PseudoAleatorios.Add(float.Parse("0." + temp));
                    x1 = float.Parse(temp);

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
