using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6___C_Sharp
{
    class Class1
    {
        public double add(double num1, double num2)
        {
            return num1 + num2;
        }


        public double sub(double num1, double num2)
        {
            return num1 - num2;
        }
        public double mul(double num1, double num2)
        {
            return num1 * num2;
        }
        public double div(double num1, double num2)
        {
            return num1 / num2;
        }



        // Polymorphism - Overloadding
        public double add(string num1, string num2)
        {
            return Convert.ToInt32(num1) + Convert.ToInt32(num2);
        }
        public double mul(double num1, double num2, double num3)
        {
            return num1 * num2 * num3;
        }
    }
}
