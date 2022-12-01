namespace Day_18___EntityFrameworkWithMVC.Extra
{
    public class Dependency2 : IDependency
    {
        public void WriteMessage(string msg)
        {
            Console.WriteLine($"Dependency 2 : {msg}");
        }
    }
}
