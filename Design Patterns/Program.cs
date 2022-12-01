namespace Day_13___Design_Patterns
{


    internal class Program
    {
       
        static void Main(string[] args)
        {
            // Creational Design Pattern

            // Non-Thread Safe Singleton Implementation

            var s1 = Singleton1.getInstance();

            Console.WriteLine(s1.number);

            s1.number = 16;

            Console.WriteLine(s1.number);

            var s2 = Singleton1.getInstance();

            Console.WriteLine(s2.number);



            // Structural Design Pattern

            // Facade Design Pattern

            FacadePattern facade = new FacadePattern();
            facade.PlaceOrder();


            // Behavioural Design Pattern

            // Template Design Pattern

            WoodHouse woodHouse = new WoodHouse();
            ConcreteHouse concreteHouse = new ConcreteHouse();

            woodHouse.BuildHouse();
            concreteHouse.BuildHouse();



        }





    }
}