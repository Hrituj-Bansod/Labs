using MultiThreading;
using MultiThreadingMore;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("-------------- MultiThreading-----------\n");

        Console.WriteLine("***** Main Thread stats *****\n");

        // Obtain and name the current thread.
        Thread primaryThread = Thread.CurrentThread;

        primaryThread.Name = "Main Thread";

        //primaryThread.Priority = ThreadPriority.Highest;            // Print out some stats about this thread.
        Console.WriteLine("Thread Name: {0}", primaryThread.Name);// ThePrimaryThread

        Console.WriteLine("Has thread started?: {0}", primaryThread.IsAlive);//true

        Console.WriteLine("Priority Level: {0}", primaryThread.Priority);//default is normal
                                                                         //
        primaryThread.Priority = ThreadPriority.Highest;
        Console.WriteLine("Priority Level: {0}", primaryThread.Priority);//
        Console.WriteLine("Thread State: {0}", primaryThread.ThreadState);// Running
        Console.WriteLine("Click to Start Multithreading Execution Loop");
        Console.ReadLine();

        Console.WriteLine("Main Thread Started");

        //Creating Threads
        Thread t1 = new Thread(Mutliprogramming.Method1)
        {
            Name = "Thread1"
        };
        Thread t2 = new Thread(Mutliprogramming.Method2)
        {
            Name = "Thread2"
        };
        Thread t3 = new Thread(Mutliprogramming.Method3)
        {
            Name = "Thread3"
        };

        //Executing the methods
        t1.Start();
        t2.Start();
        t3.Start();
        Console.WriteLine("Main Thread Ended");
        Console.WriteLine("Click to See Program for passing input or assign method to start which accepts input");
        Console.Read();

        Console.ReadLine();

        int Max = 10;
        MultiThreading.NumberHelper obj = new MultiThreading.NumberHelper(Max);

        Thread T1 = new Thread(new ThreadStart(obj.DisplayNumbers));

        T1.Start();
        Console.Read();

        Console.WriteLine("Click to See Program Retriveing data from method which is executed by thread");
        Console.Read();

        //Create the ResultCallbackDelegate instance and to its constructor 
        //pass the callback method name
        ResultCallbackDelegate resultCallbackDelegate = new ResultCallbackDelegate(ResultCallBackMethod);
        int Number = 10;
        //Creating the instance of NumberHelper class by passing the Number
        //the callback delegate instance
        MultiThreadingMore.NumberHelper obe = new MultiThreadingMore.NumberHelper(Number, resultCallbackDelegate);
        //Creating the Thread using ThreadStart delegate
        Thread T2 = new Thread(new ThreadStart(obe.CalculateSum));

        T2.Start();
        Console.Read();
    }

    //Callback method and the signature should be the same as the callback delegate signature
    public static void ResultCallBackMethod(int Result)
    {
        Console.WriteLine("The Result is " + Result);
    }
}
