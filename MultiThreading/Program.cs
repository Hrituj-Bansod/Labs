using MultiThreading;
using MultiThreadingMore;
using System.Runtime.Intrinsics.X86;

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


        Console.WriteLine("\nClick to Start Multithreading Execution Loop");
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
        Console.WriteLine("\nClick to See Program for passing input or assign method to start which accepts input");
        Console.ReadLine();

        int Max = 10;
        MultiThreading.NumberHelper obj = new MultiThreading.NumberHelper(Max);

        Thread T1 = new Thread(new ThreadStart(obj.DisplayNumbers));

        T1.Start();

        Console.WriteLine("\nClick to See Program Retriveing data from method which is executed by thread");
        Console.ReadLine();

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

        Console.WriteLine("\nClick to See Program use of Join Method");
        Console.ReadLine();

        Console.WriteLine("Main Thread Started");
        //Main Thread creating three child threads
        Thread thread1 = new Thread(Method1);
        Thread thread2 = new Thread(Method2);
        Thread thread3 = new Thread(Method3);
        thread1.Start();
        thread2.Start();
        thread3.Start();

        //Now, Main Thread will block for 3 seconds and wait thread2 to complete its execution
        if (thread2.Join(TimeSpan.FromSeconds(3)))
        {
            Console.WriteLine("Thread 2 Execution Completed in 3 second");
        }
        else
        {
            Console.WriteLine("Thread 2 Execution Not Completed in 3 second");
        }
        //Now, Main Thread will block for 3 seconds and wait thread3 to complete its execution
        if (thread3.Join(3000))
        {
            Console.WriteLine("Thread 3 Execution Completed in 3 second");
        }
        else
        {
            Console.WriteLine("Thread 3 Execution Not Completed in 3 second");
        }
        Console.WriteLine("\nClick to See Program use of Join Method");
        Console.ReadLine();

        Console.WriteLine("Main Thread Started");
        Thread thread4 = new Thread(Method4);
        thread4.Start();
        if (thread4.IsAlive)
        {
            Console.WriteLine("Thread4 Method1 is still Executing");
        }
        else
        {
            Console.WriteLine("Thread4 Method1 Completed its work");
        }
        //Wait Till thread1 to complete its execution
        thread4.Join();
        if (thread4.IsAlive)
        {
            Console.WriteLine("Thread4 Method1 is still Executing");
        }
        else
        {
            Console.WriteLine("Thread4 Method1 Completed its work");
        }
        Console.WriteLine("Main Thread Ended");
        Console.WriteLine("Click Enter  to see Program for Thread Synchronization using Lock method");
        Console.ReadLine();

        Thread t11 = new Thread(IncrementCount);
        Thread t12 = new Thread(IncrementCount);
        Thread t13 = new Thread(IncrementCount);
        t11.Start();
        t12.Start();
        t13.Start();
        //Wait for all three threads to complete their execution
        t11.Join();
        t12.Join();
        t13.Join();
        Console.WriteLine(Count);
        Console.Read();

    }

    static int Count = 0;
    private static readonly object LockCount = new object();
    static void IncrementCount()
    {
        for (int i = 1; i <= 1000000; i++)
        {
            //Only protecting the shared Count variable
            lock (LockCount)
            {
                Count++;
            }
        }
    }
    static void Method4()
    {
        Console.WriteLine("Method4 - Thread 4 Started");
        //Making thread to sleep for 2 seconds
        Thread.Sleep(TimeSpan.FromSeconds(2));
        Console.WriteLine("Method4 - Thread 4 Ended");
    }

    static void Method1()
    {
        Console.WriteLine("Method1 - Thread1 Started");
        Thread.Sleep(1000);
        Console.WriteLine("Method1 - Thread 1 Ended");
    }
    static void Method2()
    {
        Console.WriteLine("Method2 - Thread2 Started");
        Thread.Sleep(2000);
        Console.WriteLine("Method2 - Thread2 Ended");
    }
    static void Method3()
    {
        Console.WriteLine("Method3 - Thread3 Started");
        Thread.Sleep(5000);
        Console.WriteLine("Method3 - Thread3 Ended");
    }


    //Callback method and the signature should be the same as the callback delegate signature
    public static void ResultCallBackMethod(int Result)
    {
        Console.WriteLine("The Result is " + Result);
    }
}
