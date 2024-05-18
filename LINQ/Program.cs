using LINQ;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("--------------------------------------------- LINQ(Language Integrated Query) -------------------------------------------\n");

        // specify the data source 
        int[] scores = [93, 85, 95, 59, 78];

        // Define the query expression
        IEnumerable<int> scoreQuery = from score in scores where score > 80 select score;

        // Execute the Query
        foreach (var i in scoreQuery)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine("\nPress any key to see LINQ querying of your data source -  InMemory Data \n");
        Console.ReadLine();
        Console.WriteLine("\n--------------------------------------------- LINQ(Language Integrated Query) - LINQ to Objects using IEnumerable<T> -------------------------------------------\n");

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        var query = numbers.Where(n => n > 2).Select(n => n * 2);
        foreach (var item in query)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\n Press any key to see LINQ querying of your data source - InMemory Data \n");
        Console.ReadLine();
        Console.WriteLine("\n--------------------------------------------- LINQ(Language Integrated Query) -  Custom LINQ Query Providers -------------------------------------------\n");

        CustomCollection<int> customCollection = new CustomCollection<int>();
        customCollection.Add(1);
        customCollection.Add(2);
        customCollection.Add(3);
        var query1 = customCollection.Where(x => x > 1).Select(x => x * 2);
        foreach (var item in query1)
        {
            Console.WriteLine(item);
        }



    }
}