namespace Day_6___C_Sharp
{
    internal class Program
    {

       
        static void Main(string[] args)
        {
            //string addition(int num1, int num2)
            //{
            //    string res = "Addition : " + (num1 + num2);
            //    return res;
            //}
            //void subtraction(int num1, int num2)
            //{
            //    Console.WriteLine("Subtraction : " + (num1 - num2));
            //}

            //var add = addition(5, 6);
            //Console.WriteLine(add);


            //subtraction(10, 5);

            //Class1 a = new Class1();
            //Console.WriteLine("Addition : " + a.add(5, 7));
            //Console.WriteLine("Subtraction : " + a.sub(10, 7));
            //Console.WriteLine("Multiplication : " + a.mul(5, 7));
            //Console.WriteLine("Divison : " + a.div(49, 7));

            //// Polymorphism - Overloadding
            //Console.WriteLine("\nPolymorphism - Overloadding Methods");
            //Console.WriteLine("Addition with String input : " + a.add("15", "20"));
            //Console.WriteLine("Multiplication with 3 inputs : " + a.mul(5, 7, 3));


            // Inheritance 

            Cat cat1 = new Cat();

            Console.WriteLine("Cat Details: \n");
            cat1.name = "Alex";
            cat1.eat();
            cat1.sleep();
            cat1.sound();

            Dog dog1 = new Dog();

            Console.WriteLine("\nDog Details: \n");
            dog1.name = "Tom";
            dog1.eat();
            dog1.sleep();
            dog1.sound();

        }
    }
}