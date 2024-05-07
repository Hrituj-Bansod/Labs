namespace SolidPrinciples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------SOLID Principles--------------------------------------------\n\n");
            Console.WriteLine("**********Single Responsibility Principle**********\n");
            // Each class has only one functionality or logic so less maintainance and high cohesion and high reusability(use program to interface)

            // Create instances of repository and notification
            AccountRepository repository = new AccountRepository();
            AccountNotification notification = new AccountNotification();

            // Create instance of account service with dependencies injected
            AccountService accountService = new AccountService(repository, notification);

            // Open an account
            string accountDetails = "Account details go here";
            accountService.OpenAccount(accountDetails);

            Console.ReadKey(false);



            Console.WriteLine("\n\n**********Open for Extension and closed for modification**********\n");
            //classes should be open for extension, but closed for modification. In doing so, we stop ourselves from modifying existing code and causing potential new bugs in an otherwise running application

            // Create an instance of SuperCoolGuitarWithFlames
            SuperCoolGuitarWithFlames guitar = new SuperCoolGuitarWithFlames("Fender", "Stratocaster", 10, "Red");

            // Display guitar details
            guitar.DisplayDetails();
            Console.ReadKey(false);

            Console.WriteLine("\n\n**********Liskove Substitution Principle**********\n\n");
            //The principle defines that objects of a superclass shall be replaceable with objects of its subclasses without breaking the application. That requires the objects of your subclasses to behave in the same way as the objects of your superclass. 
            // Create instances of FourWheeler and Car
            FourWheeler fourWheeler = new FourWheeler();
            Car car = new Car();

            // Perform actions
            Perform(fourWheeler);
            Perform(car);
            Console.ReadKey(false);

            Console.WriteLine("\n\n**********Interface segregation principle**********\n\n");
            //A client should never be forced to implement an interface that it doesn’t use or clients shouldn’t be forced to depend on methods they do not use.

            // Create instances of mouse listener and mouse motion listener
            MyMouseListener mouseListener = new MyMouseListener();
            MyMouseMotionListener mouseMotionListener = new MyMouseMotionListener();

            // Simulate mouse events
            MouseEvent mouseEvent = new MouseEvent { X = 100, Y = 200 };
            mouseListener.MouseClicked(mouseEvent);
            mouseMotionListener.MouseMoved(mouseEvent);
            Console.ReadKey(false);

            Console.WriteLine("\n\n**********Dependency Inversion Principle**********\n\n");
            //The Dependency Inversion Principle (DIP) says that a "high-level class" must not depend upon a "lower-level class".
            //now there are two ways to follow Dependency Inversion Principle:

            //a) Traditional way:  Program to interface
            //b) b) IOC - aka  Dependency Injection

            ILogger fileLogger = new FileLogger();
            DataAccessLayer dataAccessLayer1 = new DataAccessLayer(fileLogger);
            dataAccessLayer1.AddCustomer("John");

            ILogger consoleLogger = new ConsoleLogger();
            DataAccessLayer dataAccessLayer2 = new DataAccessLayer(consoleLogger);
            dataAccessLayer2.AddCustomer("Alice");

            Console.WriteLine("Press Enter to Stop the Application");
            Console.ReadKey(false);
        }

        public static void Perform(FourWheeler f)
        {
            f.Start();
            f.Stop();
        }
    }
}
