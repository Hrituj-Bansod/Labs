using PasswordGenerator;

internal class Program
{
    private static void Main(string[] args)
    {
        var pwd = new Password();
        var password = pwd.Next();
        Console.WriteLine("Generated password : " + password.ToString());
    }
}