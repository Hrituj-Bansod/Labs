using MyNamespace;
internal class Program
{
    private static void Main(string[] args)
    {
        // linq 

        // Specify the data source.
        int[] scores = [98,101,204,59,06,43,90];

        // Define the query expression.
        IEnumerable<int> scoreQuery =
            from score in scores
            where score > 60
            select score;

        // Execute the query.Here it is executed
        foreach (var i in scoreQuery)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();


        // sorting along with
        // similar to query langauge 
        IEnumerable<int> scoredQuery =
            from score in scores
            where score > 60
            orderby score descending
            select score;

        // Execute the query.Here it is executed
        foreach (var i in scoredQuery)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();


        // but still repetitive right, solution down below 
        IEnumerable<string> highScoresQuery2 =
        from score in scores
        where score > 80
        orderby score descending
        select $"The score is {score}";

        foreach (string i in highScoresQuery2)
        {
            Console.Write(i);
        }
        Console.WriteLine();


        // executed because ask for it using count()
        var highScoreCount = (
        from score in scores
        where score > 80
        select score
        ).Count();

        Console.WriteLine(highScoreCount);


        // uptil now is syntactical sugar now method syntax
        var newQuery = scores.Where(s => s > 60).OrderByDescending(s => s);

        // Execute the query.Here it is executed
        foreach (var i in newQuery)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();


        // object oriented programming 
        var person1 = new Person1( "proire", "sadah",new DateOnly(1995, 8, 3) );
        var person2 = new Person2() { firstname = "myman", lastname = "sadah", birthday = new DateOnly(1994, 8, 2) };


        // collections and oops 
        Person3 person3 = new Person3("proire", "sadah", new DateOnly(1995, 8, 3));
        Person3 person3again = new Person3("sakurama", "amarkas", new DateOnly(1997, 3, 5));
        List<Person3> persons = [ person3, person3again];
        Console.WriteLine(persons.Count);

        person3.Pets.Add(new Dog("Raja"));
        person3.Pets.Add(new Dog("Moti"));

        person3again.Pets.Add(new Cat("Beyonce"));

        foreach(var person in persons)
        {
            Console.WriteLine($"{person}");
            foreach(var pet in person.Pets)
            {
                Console.WriteLine($"  {pet}");
            }
        }
    }
}