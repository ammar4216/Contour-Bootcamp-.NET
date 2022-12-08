using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class SumSequence
    {
       public int sumSequence(string num)
        {

            int sum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                sum += int.Parse(num.Substring(i, 1));
            }

            return sum;
        }
    }
}
