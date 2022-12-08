namespace Assignment_3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Name: Ammar Ahmed");
            Console.WriteLine("TechLift Bootcamp Web Engineering in .NET (Contour Software)\n\n");
            //SUM Sequence

            Console.WriteLine("Sum Sequence Program");
            Console.WriteLine("\nEnter Numbers for SUM");
            var num = Console.ReadLine();
            SumSequence sumNumber = new SumSequence();
            Console.WriteLine(sumNumber.sumSequence(Convert.ToString(num)));

            // Prime Number
            Console.WriteLine("\n\nPrime Number Program");
            PrimeNumber primeNumber = new PrimeNumber();
            primeNumber.isPrime(31);
            primeNumber.isPrime(10);

            // Pattern
            Console.WriteLine("\n\nPattern Program");
            Pattern pattern = new Pattern();
            pattern.pattern();


            


            
        }
    }
}