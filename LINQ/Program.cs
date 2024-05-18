internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("--------------------------------------------- LINQ(Language Integrated Query) -------------------------------------------");

        // specify the data source 
        int[] scores = [93, 85, 95, 59, 78];

        // Define the query expression
        IEnumerable<int> scoreQuery = from score in scores where score > 80 select score;

        // Execute the Query
        foreach (var i in scoreQuery)
        {
            Console.Write(i + " ");
        }
    }
}