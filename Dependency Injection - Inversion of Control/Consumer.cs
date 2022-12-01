using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection___Inversion_of_Control
{
    public class Consumer 
    {
        private IDependency _dependency;

        public Consumer(IDependency dependency)
        {
            _dependency = dependency;
        }

        public void ConsumeThings()
        {
            _dependency.WriteMessage("Hello World");
        }
    }
}
