using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
     class Pattern
    {
        public void pattern()
        {
            for(int i = 1; i < 10; i++)
            {
                for(int j = 10; j > i; j--)
                {
                    Console.Write(" ");
                }
                for(int k = 1; k < i; k++)
                {
                    Console.Write(k);
                }
                for(int l = i - 2; l >= 1; l--)
                {
                    Console.Write(l);
                }
                Console.WriteLine("\n");
            }
        }
    }
}
