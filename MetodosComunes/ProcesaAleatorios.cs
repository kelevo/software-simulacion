using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosComunes
{
    public class ProcesaAleatorios
    {
        public string CreaTexto(List<float> aleatorios)
        {
            string texto = "";
            //1.- 6789
            //2.- 8906

            for (int i = 0; i < aleatorios.Count; i++)
            {
                texto = texto + "\r\n" + (i + 1) + ".- " + aleatorios[i];
            }

            return texto;
        }

    }
}
