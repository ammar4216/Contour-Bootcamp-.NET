using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13___Design_Patterns
{
    public abstract class TemplatePattern
    {
        public void BuildHouse()
        {
            Console.WriteLine("\n\nHouse Build Starting....");
            Foundation();
            BuildPillars();
            BuildWalls();
            BuildWindows();
            BuildDoors();
            Console.WriteLine("\nHouse Build completed..!!!");
        }

        protected abstract void Foundation();
        protected abstract void BuildPillars();
        protected abstract void BuildWalls();
        protected abstract void BuildWindows();
        protected abstract void BuildDoors();
    }


    public class WoodHouse : TemplatePattern
    {
        protected override void BuildDoors()
        {
            Console.WriteLine("Wood Doors");
        }

        protected override void BuildPillars()
        {
            Console.WriteLine("Wood Pillars");
        }

        protected override void BuildWalls()
        {
            Console.WriteLine("Wood Walls");
        }

        protected override void BuildWindows()
        {
            Console.WriteLine("Wood Windows");
        }

        protected override void Foundation()
        {
            Console.WriteLine("Foundation");
        }
    }

    public class ConcreteHouse : TemplatePattern
    {
        protected override void BuildDoors()
        {
            Console.WriteLine("Concrete Doors");
        }

        protected override void BuildPillars()
        {
            Console.WriteLine("Concrete Pillars");
        }

        protected override void BuildWalls()
        {
            Console.WriteLine("Concrete Walls");
        }

        protected override void BuildWindows()
        {
            Console.WriteLine("Concrete Windows");
        }

        protected override void Foundation()
        {
            Console.WriteLine("Foundation");
        }
    }
}
