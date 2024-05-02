internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Stack OverFlow Exception");

        try
        {
                StackOverFlowMethod();
        }
        catch (StackOverflowException ie)
        {
            Console.WriteLine(ie.Message);
        }
    }

    public static void StackOverFlowMethod()
    {
        Console.WriteLine("hello");
        StackOverFlowMethod();
    }
}