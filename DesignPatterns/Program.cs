namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------Design Patterns---------------------------------------\n\n");
            Console.WriteLine("**********************Singleton Pattern*********************\n\n");

            // Get the singleton instance
            Singleton instance1 = Singleton.GetSingleton();
            Singleton instance2 = Singleton.GetSingleton();

            // Check if both instances are the same
            if (instance1 == instance2)
            {
                Console.WriteLine("Both instances are the same.");
            }
            else
            {
                Console.WriteLine("Instances are different.");
            }

            Console.WriteLine("\n\nEnter the key for Factory Pattern\n\n");
            Console.ReadKey(false);
            Console.WriteLine("**********************Factory Pattern*********************\n\n");

            // Example of program to implementation
            WindowsUIComponentCreator windowsUIComponentCreator = new WindowsUIComponentCreator();
            windowsUIComponentCreator.Show("Button");

            LinuxUIComponentCreator linuxUIComponentCreator = new LinuxUIComponentCreator();
            linuxUIComponentCreator.Show("TextField");

            MacUIComponentCreator macUIComponentCreator = new MacUIComponentCreator();
            macUIComponentCreator.Show("CheckBox");


            // Example of program to interface - this is heavily followed in industry example of jar files of drivers from vendors 
            UIComponentCreator uiComponentCreator = new WindowsUIComponentCreator();
            uiComponentCreator.Show("Button");

            uiComponentCreator = new LinuxUIComponentCreator();
            uiComponentCreator.Show("TextField");

            uiComponentCreator = new MacUIComponentCreator();
            uiComponentCreator.Show("CheckBox");


            Console.WriteLine("\n\nEnter the key for Adapter Pattern\n\n");
            Console.ReadKey(false);
            Console.WriteLine("**********************Adapter pattern*********************\n\n");

            RectangularPlug plug = new RectangularPlug();
            plug.GetPower();

            Console.WriteLine("\n\nEnter the key for Fascade Pattern\n\n");
            Console.ReadKey(false);
            Console.WriteLine("**********************Fascade pattern*********************\n\n");

            TravelFacade facade = new TravelFacade();
            DateTime from = DateTime.Today;
            DateTime to = DateTime.Today.AddDays(7);
            facade.GetFlightsAndHotels(from, to);

        }
    }
}
