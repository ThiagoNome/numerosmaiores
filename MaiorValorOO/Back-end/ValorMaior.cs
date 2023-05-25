using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorValorOO.Back_end
{
     class ValorMaior
    {
        public string CalcularMaiorValor(int v1, int v2, int v3)
        {
            int valor1 = v1;
            int valor2 = v2;
            int valor3 = v3;
            int maiorValor;

            string resp;

            if (valor1 > valor2 && valor1 > valor3)
            {
                maiorValor = valor1;
            }
            else if (valor2 > valor1 && valor2 > valor3)
            {
                maiorValor = valor2;
            }
            else
            {
                maiorValor = valor3;
            }

            resp = "O maior número é " + maiorValor;

            return resp;
        }
    }
}
