using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantoneira
{
    internal class CalculoCantoneira
    {
     
        public List<string> Cantoneira(int n)
        {
            List<string> valor = new List<string>();
            for (int x = 1; x <= 1; x++)
            {
                string espaco = new string(' ',n + x);
                string numero = "";
                 
                for (int y = 1; y <= n; y++)
                {
                    numero += y;

                    valor.Add(numero);
                }
            }
            return valor;
        }
    }   
}
