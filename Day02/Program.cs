using PasswordGenerator;
using System.ComponentModel;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        var pwd = new Password();
        var password = pwd.Next();
        Console.WriteLine("Generated password : " + password.ToString());

        // dealing with spaces
        String greeting = "  Hello prasad   ";
        Console.WriteLine($"[{greeting}]");   // same at is 

        Console.WriteLine($"[{greeting.TrimStart()}]"); // remove space from beginning
    
        Console.WriteLine($"[{greeting.TrimEnd()}]"); // remove at end
    
        Console.WriteLine($"[{greeting.Trim()}]");  // remove from both

        // dealing with searching - Replace() 
        string trimmedGreeting = greeting.Trim();
        string replaceName = trimmedGreeting.Replace("asad","oire");
        Console.WriteLine($"[{replaceName}]");

        // observer something carefully - Replace
        Console.WriteLine($"[{trimmedGreeting.Replace("asad","oire")}]");  // This only changes the string on output.
        Console.WriteLine($"[{trimmedGreeting}]");

        // Contains method
        Console.WriteLine($"[{trimmedGreeting.Contains("pro")}]");

        // ToUpper method
        Console.WriteLine($"[{trimmedGreeting.ToUpper()}]");

        // Length method
        Console.WriteLine($"[{trimmedGreeting.Length}]");

        // StartsWith method  
        Console.WriteLine($"[{trimmedGreeting.StartsWith("pro")}]");

        // significant white space matters inside quotes only but when it comes to ide it doesn't matter how we organize the code 


        // Maths, Integers and Numbers 
        int a = 18;
        int b = 6;
        int c = a + b;
        Console.WriteLine($"Addition of {a} and {b} is {c}");

        // squiggle error - overflow 
        int x= 2000000000; 
        int y = 600000000;
        int z = x + y;
        Console.WriteLine($"Addition of {x} and {y} is {z}");

        // solution  - still problem - same squiggle problem
        long l = x + y;
        Console.WriteLine($"Addition of {x} and {y} is {l}");
        // what is happening math  is adding two numbers and store it in int and then passed the result to long 

        long j = (long)x + y;  // solves the problem 
        Console.WriteLine($"Addition of {x} and {y} is {j}");

        // but still i don't want the program to give me wrong input it should give me erro when it had overflow 
        //int k = checked(x + y); // runtime exception 
        //Console.WriteLine($"Addition of {x} and {y} is {k}");

        // floating numbers -- why int a = 20.34 gives error 
        // try out cast - i don't care i want that it in int

        int newnum = (int)49.32;
        Console.WriteLine($"Newnum is {newnum}");

        // correct way to deal with floating point 
        float singleprecision = 20.3F;
        double doubleprecision = 30.45; // natural type 
        double add = singleprecision+ doubleprecision;
        Console.WriteLine($"Addition of firstnum {singleprecision} and secondnum  {doubleprecision} is {add}");
        // output - accuracy - precision

        // decimal - solution accurate - more space to store these number 
        decimal firstdecimal = 20.3M;
        decimal seconddecimal = 30.45M; //explicit type 
        decimal result = firstdecimal+ seconddecimal;
        Console.WriteLine($"Addition of firstnum {firstdecimal} and secondnum  {seconddecimal} is {result}");




        // Control statements 
        int num = 10;
        if (20 > num)
            Console.WriteLine($"yes {num} is less than 20");

        // PEDMAS and BODMAS - evaluate something first than other thing operations

        // bool datatype usage
        bool flag = 20 > num;
        if(flag)
            Console.WriteLine($"yes {num} is less than 20");


        // if - else
        if(num>20)
            Console.WriteLine($"yes {num} is less than 20");
        else
            Console.WriteLine($"No {num} is less than 20");

        // complicated if condition 
        if(num>5 && num%2==0)
            Console.WriteLine($"yes {num} is greater than 5 and even number");
        else
            Console.WriteLine($"No {num} is greater than 5 or even number");

        // or 
        if (num > 20 || num % 2 == 0)
            Console.WriteLine($"yes {num} is greater than 20 0r even number");
        else
            Console.WriteLine($"No {num} is neither greater than 20 nor even number");

        // branching and loops 
        int counter = 0;
        counter = counter + 1;
        Console.WriteLine(counter);
        counter = counter + 1;
        Console.WriteLine(counter);
        counter = counter + 1;
        Console.WriteLine(counter);
        counter++;  // improved version ++ instead of + 1
        Console.WriteLine(counter);

        // use loops - repeated things into easy and consize code 
        int count = 0;
        while(count < 5)
        {
            Console.WriteLine(count);
            count++;
        }


        // do while - first execute one time and then check for repetation
        do
        {
            Console.WriteLine(count);
            count++;
        }
        while (count < 10);

        // for loop - we know before execution how many times to do this thing 
        for(int i=0; i< 10; i++)
        {
            Console.WriteLine(i);
        }


        // nested loops 
        for (int i = 0; i < 10; i++)
        {
            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine(i + k);
            }
        }


        // collections in c# - List<T> List of types T 

        var names = new List<string>() { "pro", "har", "sha"};
        foreach(var name in names)
        {
            Console.WriteLine(name);
        }

        // new - creating an object - made a list of string 
        // List<string>? -- null allowed 

        // second way of iterating using original for loop 
        for(int i=0; i<names.Count; i++)
        {
            Console.WriteLine(names[i]);
        }

        // methods on list 
        names.Add("AB");
        names.Remove("har");

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        // Arrays, Lists, Indexing and Foreach
        Console.WriteLine(names[1]);
        Console.WriteLine(names[names.Count-1]);
        Console.WriteLine(names[^1]);
        // count 1 from the back 


        

        // Arrays - primitive type for storing sequence of data
        var newarray = new string[] { "go", "for", "it" };
        foreach(var name in newarray)
        {
            Console.WriteLine(name);
        }
    }
}