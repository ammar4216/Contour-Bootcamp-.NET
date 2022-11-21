using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13___Design_Patterns
{

    // Non-Thread Safe Singleton Implementation

    public class Singleton1
    {
        public int number = 13;
        private Singleton1()
        {

        }

        public static Singleton1 Instance = null;

        public static Singleton1 getInstance()
        {
            if (Instance == null)
            {
                Instance = new Singleton1();
            }

            return Instance;
        }
    }
}
