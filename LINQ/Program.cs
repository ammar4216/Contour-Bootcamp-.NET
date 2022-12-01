using System.Linq;

namespace Day_8___Enum_and_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Enumerations

            //Console.WriteLine("Enter Selection: \n");
            //Console.WriteLine("0. Addition");
            //Console.WriteLine("1. Subtraction");
            //Console.WriteLine("2. Multiplication");
            //Console.WriteLine("4. Division\n");

            //string inp = Console.ReadLine();
            //int input = int.Parse(inp);

            //var selection = (Constantsss)input;

            //switch (selection)
            //{
            //    case Constantsss.Addition:
            //        break;
            //    case Constantsss.Subtraction:
            //        break;
            //    case Constantsss.Multiplication:
            //        break;
            //    case Constantsss.Division:
            //        break;
            //    default:
            //        break;
            //}



            // LINQ

            //string[] str = { "Apple", "Banana", "Orange", "Mango"};

            //var res = from i in str where i.Length > 5 select i;

            //foreach(var item in res)
            //{
            //    Console.WriteLine(item + " Hello");
            //}


            //int[] numbers = { 44, 55, 66, 77, 12, 17, 36, 10, 33, 5 };

            //var res = from i in numbers where i > 20 select i;

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            var res = from i in days select i;

            foreach (var item in res)
            {
                Console.WriteLine("Day " + item + " & Length is " + item.Length);
            }


        }
    }
}