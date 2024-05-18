using LINQ;
using System.Xml.Linq;

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
        Console.WriteLine();

        Console.WriteLine("\nPress any key to see LINQ querying of your data source -  InMemory Data \n");
        Console.ReadLine();
        Console.WriteLine("\n--------------------------------------------- LINQ(Language Integrated Query) - LINQ to Objects using IEnumerable<T> -------------------------------------------\n");

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        var query = numbers.Where(n => n > 2).Select(n => n * 2);
        foreach (var item in query)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nPress any key to see LINQ querying of your data source - InMemory Data \n");
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

        Console.WriteLine("\nPress any key to see LINQ querying of your data source -  Remote Data \n");
        Console.ReadLine();
        Console.WriteLine("\n--------------------------------------------- LINQ(Language Integrated Query) - Less Complex IQueryable Providers -------------------------------------------\n");

            // Create some dummy data for the XML file
            XElement contacts =
                new XElement("Contacts",
                    new XElement("Contact",
                        new XElement("Name", "John Doe"),
                        new XElement("Email", "john@example.com"),
                        new XElement("Phone", "1234567890")
                    ),
                    new XElement("Contact",
                        new XElement("Name", "Jane Smith"),
                        new XElement("Email", "jane@example.com"),
                        new XElement("Phone", "0987654321")
                    )
                );

            // Save the dummy data to an XML file
            contacts.Save(@"C:\Users\proir\Desktop\Training\Day01\LINQ\RemoteData.xml");

            // Load the XML file and query it using LINQ
            XElement loadedContacts = XElement.Load(@"C:\Users\proir\Desktop\Training\Day01\LINQ\RemoteData.xml");

            // Query the contacts for those with a specific name
            var query2 =
                from contact in loadedContacts.Elements("Contact")
                where (string)contact.Element("Name") == "John Doe"
                select contact;

            // Display the results
            foreach (var result in query2)
            {
                Console.WriteLine("Name: " + result.Element("Name").Value);
                Console.WriteLine("Email: " + result.Element("Email").Value);
                Console.WriteLine("Phone: " + result.Element("Phone").Value);
                Console.WriteLine();
            }

    }
}