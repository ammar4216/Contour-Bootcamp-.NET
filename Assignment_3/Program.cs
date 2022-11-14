namespace Assignment_3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            // Prime Number
            PrimeNumber primeNumber = new PrimeNumber();
            primeNumber.isPrime(31);
            primeNumber.isPrime(10);

            // Pattern
            Pattern pattern = new Pattern();
            pattern.pattern();
            
        }
    }
}