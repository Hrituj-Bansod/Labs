using System.Reflection;
using System.Runtime.ExceptionServices;

namespace Day13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Memory Management!");

            Hondacity? hondacity = new Hondacity();
            hondacity = null;

            // Reflection 
            // You can use reflection to dynamically create an instance of a type, bind the type to an existing object, or get the type from an existing object. 
            // Gets the mscorlib assembly in which the object is defined.
            Assembly assembly = typeof(object).Module.Assembly;


            // Loads an assembly using its file name.
            Assembly a = Assembly.LoadFrom("Day13.dll");  // not exe just dll file
            // Gets the type names from the assembly.
            Type[] types2 = a.GetTypes();
            foreach (Type t in types2)
            {
                Console.WriteLine(t.FullName);
            }
            Console.WriteLine();
            foreach (Type t in types2)
            {
                foreach(MemberInfo m in t.GetMembers())
                {
                    Console.WriteLine(m.Name);
                }
            }
            Console.WriteLine();
            int Count = 0;
            foreach (Type t in types2)
            {
                if(Count++<2)
                    Console.WriteLine("Module Assembly Name :"+t.Module.Assembly);
                else
                    Console.WriteLine("Module Name :"+t.Module);
            }
            Console.WriteLine();
            Type type = typeof(System.String);
            Console.WriteLine("Listing all the public constructors of the {0} type", type);
            // Constructors.
            ConstructorInfo[] ci = type.GetConstructors(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine("//Constructors");
            PrintMembers(ci);


            Console.WriteLine("\nReflection.MemberInfo");
            // Gets the Type and MemberInfo.
            Type myType = Type.GetType("System.IO.File");
            MemberInfo[] myMemberInfoArray = myType.GetMembers();
            // Gets and displays the DeclaringType method.
            Console.WriteLine("\nThere are {0} members in {1}.",
                myMemberInfoArray.Length, myType.FullName);
            Console.WriteLine("{0}.", myType.FullName);
            if (myType.IsPublic)
            {
                Console.WriteLine("{0} is public.", myType.FullName);
            }



            Console.WriteLine("Reflection.MethodInfo");
            // Gets and displays the Type.
            Type myType1 = Type.GetType("System.Reflection.FieldInfo");
            // Specifies the member for which you want type information.
            MethodInfo myMethodInfo = myType1.GetMethod("GetValue");
            Console.WriteLine(myType1.FullName + "." + myMethodInfo.Name);
            // Gets and displays the MemberType property.
            MemberTypes myMemberTypes = myMethodInfo.MemberType;
            if (MemberTypes.Constructor == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type All");
            }
            else if (MemberTypes.Custom == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type Custom");
            }
            else if (MemberTypes.Event == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type Event");
            }
            else if (MemberTypes.Field == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type Field");
            }
            else if (MemberTypes.Method == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type Method");
            }
            else if (MemberTypes.Property == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type Property");
            }
            else if (MemberTypes.TypeInfo == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type TypeInfo");
            }


            // Specifies the class.
            Type t2 = typeof(System.IO.BufferedStream);
            Console.WriteLine("Listing all the members (public and non public) of the {0} type", t2);

            // Lists static fields first.
            FieldInfo[] fi = t2.GetFields(BindingFlags.Static |
                BindingFlags.NonPublic | BindingFlags.Public);
            Console.WriteLine("// Static Fields");
            PrintMembers(fi);

            // Static properties.
            PropertyInfo[] pi = t2.GetProperties(BindingFlags.Static |
                BindingFlags.NonPublic | BindingFlags.Public);
            Console.WriteLine("// Static Properties");
            PrintMembers(pi);

            // Static events.
            EventInfo[] ei = t2.GetEvents(BindingFlags.Static |
                BindingFlags.NonPublic | BindingFlags.Public);
            Console.WriteLine("// Static Events");
            PrintMembers(ei);

            // Static methods.
            MethodInfo[] mi = t2.GetMethods(BindingFlags.Static |
                BindingFlags.NonPublic | BindingFlags.Public);
            Console.WriteLine("// Static Methods");
            PrintMembers(mi);

            // Constructors.
            ConstructorInfo[] cit = t2.GetConstructors(BindingFlags.Instance |
                BindingFlags.NonPublic | BindingFlags.Public);
            Console.WriteLine("// Constructors");
            PrintMembers(cit);

            // Instance fields.
            fi = t2.GetFields(BindingFlags.Instance | BindingFlags.NonPublic |
                BindingFlags.Public);
            Console.WriteLine("// Instance Fields");
            PrintMembers(fi);

            // Instance properties.
            pi = t2.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic |
                BindingFlags.Public);
            Console.WriteLine("// Instance Properties");
            PrintMembers(pi);

            // Instance events.
            ei = t2.GetEvents(BindingFlags.Instance | BindingFlags.NonPublic |
                BindingFlags.Public);
            Console.WriteLine("// Instance Events");
            PrintMembers(ei);

            // Instance methods.
            mi = t2.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic
                | BindingFlags.Public);
            Console.WriteLine("// Instance Methods");
            PrintMembers(mi);

            Console.WriteLine("\r\nPress ENTER to exit.");
            Console.Read();



            // closure Usage Code 
            ClosureExample example = new ClosureExample();
            Func<int, int> closure = example.CreateClosure();

            int result = closure(5);
            int anotherresult = closure(10);

            Console.WriteLine($"First Result : {result} Second Result : {anotherresult}");

        }

        public static void PrintMembers(MemberInfo[] ms)
        {
            foreach (MemberInfo m in ms)
            {
                Console.WriteLine("{0}{1}", "     ", m);
            }
            Console.WriteLine();
        }
    }
}
