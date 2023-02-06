using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosComunes
{
    public class ProcesaAleatorios2
    {
        public string CreaTexto2(List<float> aleatorios2)
        {
            string texto = "";
            //1.- 6789
            //2.- 8906

            for (int i = 0; i < aleatorios2.Count; i++)
            {
                texto = texto + "\r\n" + (i + 1) + ".- " + aleatorios2[i];
            }

            return texto;
        }
    }
}
