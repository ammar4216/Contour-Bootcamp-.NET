namespace Day_7___OOP
{

    // Multiple Inheritance with Interfaces
    interface  iAnimal1
    {
        public  void Sleep();
        public  void Eat();
        
    }

    interface iAnimal2
    {
        public void Run();
        public void Awake();

    }

    class Dog : iAnimal1, iAnimal2
    {
        public void Awake()
        {
            Console.WriteLine("Awake...");
        }

        public void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public void Run()
        {
            Console.WriteLine("Running...");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleeping...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.Sleep();
            d.Eat();
            d.Run();
            d.Awake();
            
        }
    }
}