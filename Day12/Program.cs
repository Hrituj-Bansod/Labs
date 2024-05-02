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

            // Usage of Delegate in code: - 
            // Instantiate the delegate.
            Callback handler = DelegateMethod;

            // Call the delegate by passing delegate to method as parameter 
            MethodWithCallback(1, 2, handler);

            // Multicast delegates
            var obj = new MethodClass();
            Callback d1 = obj.Method1;
            Callback d2 = obj.Method2;
            Callback d3 = DelegateMethod;

            //Both types of assignment are valid.
            Callback allMethodsDelegate = d1 + d2;
            allMethodsDelegate += d3;
            MethodWithCallback(1, 2, allMethodsDelegate);
        }
        
        // Delegates - A delegate is a type that represents references to methods with a particular parameter list and return type. Delegates are used to pass methods as arguments to other methods
        //declares a delegate named Callback that can encapsulate a method that takes a string as an argument and returns void:
        public delegate void Callback(string message);

        // Create a method for a delegate.
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }

        // Method with call back
        public static void MethodWithCallback(int param1, int param2, Callback callback)
        {
            callback("The number is: " + (param1 + param2).ToString());
        }
    }
}
