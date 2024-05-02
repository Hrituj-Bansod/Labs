namespace Day12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Records Type
            Console.WriteLine("Record type\n");

            Player player1 = new("Proire", 1000, 15);
            Player player2 = new("Faker", 1500, 7);

            Console.WriteLine($"Player 1: {player1.Name}, Score: {player1.Score}, Level: {player1.Level}");
            Console.WriteLine($"Player 2: {player2.Name}, Score: {player2.Score}, Level: {player2.Level}");

            // Equality comparison
            if (player1.Equals(player2))
            {
                Console.WriteLine("Players are equal.");
            }
            else
            {
                Console.WriteLine("Players are not equal.");
            }

            Console.WriteLine($"{player1}");
            Console.WriteLine($"{player2}");

        }
    }
}
