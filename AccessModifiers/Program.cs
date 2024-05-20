using MyLibrary;
namespace AccessModifiers
{
    internal class Program : PrintDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------- Using Library MyLibrary and access Methods ---------------\n");
            Greet("Prasad");
        }
    }
}
