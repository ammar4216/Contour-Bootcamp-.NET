namespace Dependency_Injection___Inversion_of_Control
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDependency MD = new Dependency1();

            var consumer = new Consumer(MD);
            consumer.ConsumeThings();
        }
    }
}