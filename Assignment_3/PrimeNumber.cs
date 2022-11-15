using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class PrimeNumber
    {
        public void isPrime(int num1)
        {
            bool flag = false;

            if (num1 == 0 || num1 == 1)
            {
                flag = true;
            }

            for (int i = 2; i <= num1 / 2; i++)
            {
                if (num1 % i == 0)
                {
                    flag = true;
                    break;
                }
            }

            if (flag == false)
            {
                Console.WriteLine(num1 + " is a Prime Number");
            }
            else
            {
                Console.WriteLine(num1 + " is not a Prime Number");
            }


        }
    }
}
