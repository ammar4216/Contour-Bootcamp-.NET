namespace Day_18___EntityFrameworkWithMVC.Extra
{
    public class Dependency1 : IDependency
    {
        public void WriteMessage(string msg)
        {
            Console.WriteLine($"Dependency 1 : {msg}");
        }
    }
}
