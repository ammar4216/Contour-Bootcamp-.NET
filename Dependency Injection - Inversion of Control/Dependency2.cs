﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection___Inversion_of_Control
{
    public class Dependency2 : IDependency
    {
        
        public void WriteMessage(string msg)
        {
            Console.WriteLine($"Dependency 2 : {msg}");
        }
    }
}