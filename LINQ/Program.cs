internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("--------------------------------------------- LINQ(Language Integrated Query) -------------------------------------------/n");

        // specify the data source 
        int[] scores = [93, 85, 95, 59, 78];

        // Define the query expression
        IEnumerable<int> scoreQuery = from score in scores where score > 80 select score;

        // Execute the Query
        foreach (var i in scoreQuery)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine("/n Press any key to see LINQ querying of your data source /n");
        Console.ReadLine();
        Console.WriteLine("/n--------------------------------------------- LINQ(Language Integrated Query) - LINQ to Objects using IEnumerable<T> -------------------------------------------/n");
    }
}