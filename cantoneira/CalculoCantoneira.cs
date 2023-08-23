using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantoneira
{
    internal class CalculoCantoneira
    {
        public int Cantoneira(int n)
        {
            for (int x = 0;x <=n;x++)
            {
                Console.WriteLine(x);
                if (x == 0)
                {
                    break;
                }
                else
                {
                    for(int y = 1; y<=x;y++)
                    {
                        if(x>=y)
                        {
                            return y;
                        }
                    }
                }
            }
        }
    }
}
