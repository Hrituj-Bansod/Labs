namespace SoftwareDesignPrinciples_DRY_KISS_YAGNI_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------Software Design principles--------------------------------------\n\n");
            Console.WriteLine("****************Keep it simple, stupid!**************\n\n");
            int day;
            KISSDemo demo = new KISSDemo();
            Console.Write("Enter the Day of the Week : ");
            int.TryParse(Console.ReadLine(), out day);
            Console.WriteLine("Week of the Day is "+demo.weekday1(day));
            Console.WriteLine("Week of the Day is " + demo.weekday2(day));

            Console.WriteLine("\n\n****************DRY**************\n\n");

            Console.WriteLine("Without using DRY Priniciple");
            // Taking inputs as x and y
            Console.Write("Enter the value of x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter the value of y: ");
            int y = int.Parse(Console.ReadLine());

            // Calculating x raised to 3
            int ans1 = 1;
            for (int i = 1; i <= 3; i++)
            {
                ans1 *= x;
                // means ans1=ans1*x;
            }
            Console.WriteLine("x raised to the power 3 = " + ans1);

            // Calculating y raised to 5
            int ans2 = 1;
            for (int i = 1; i <= 5; i++)
            {
                ans2 *= y;
                // means ans2=ans2*y;
            }
            Console.WriteLine("y raised to the power 5 = " + ans2);
            Console.WriteLine("Enter key for DRY Version of Code .. ");
            Console.ReadKey();

            Console.WriteLine("\n\nWith DRY Priniciple");

            GFGCalc obj = new GFGCalc();

            // calling CalcPow() method
            int ans3 = obj.CalcPow(x, 3);
            int ans4 = obj.CalcPow(y, 5);

            Console.WriteLine("x raised to 3 = " + ans3);
            Console.WriteLine("y raised to 5 = " + ans4);


           
            Console.WriteLine("Enter key for YAGNI Principle .. ");
            Console.ReadKey();
            Console.WriteLine("\n\n****************YAGNI(You Aren't Gonna Need It)**************\n\n");

            // Without YAGNI
            IDataRepository dataRepository = new SqlDataRepository();
            dataRepository.SaveData("Kya hain yeh Data");

            // With YAGNI
            DataProcessor dataProcessor = new DataProcessor();
            dataProcessor.ProcessData("Data is new fuel");

            Console.WriteLine("Enter key for Exit Application.. ");
            Console.ReadKey();
        }
    }
}
