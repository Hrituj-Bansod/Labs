using System.Text;

namespace FileHandling
{
    internal class Program
    {
        const string fileName = "AppSettings.dat";
        static void Main(string[] args)
        {
            Console.WriteLine("File Handling\n");

            Console.Write("BinaryReader/Binary Writer --> ");
            // Derived from Object class. Reads and Writes (discrete)primitive data types as binary values in a specific encoding(binray format).
            // How to store and retrive application settings in files.

            WriteDefaultValues();
            DisplayValues();

            Console.Write("MarshelByRefObject Class --> ");
            // Enables access to objects across application domain boundaries in applications that support remoting.

            Console.Write("stream class --> ");
            // Provides a generic view of a sequence of bytes. This is an abstract class.

            Console.Write("FileStream class\n");
            //Provides a Stream for a file, supporting both synchronous and asynchronous read and write operations.

            string path = @"C:\Users\proir\Desktop\Training\Day01\FileHandling\MyTest.txt";

            Console.WriteLine("Filestream writing .. \n");
            // Delete the file if it exists.
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            //Create the file.
            using (FileStream fs = File.Create(path))
            {
                AddText(fs, "This is some text");
                AddText(fs, "This is some more text,");
                AddText(fs, "\r\nand this is on a new line");
                AddText(fs, "\r\n\r\nThe following is a subset of characters:\r\n");

                for (int i = 1; i < 120; i++)
                {
                    AddText(fs, Convert.ToChar(i).ToString());
                }
            }

            Console.WriteLine("Filestream Reading .. \n");
            //Open the stream and read it back.
            using (FileStream fs = File.OpenRead(path))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                int readLen;
                while ((readLen = fs.Read(b, 0, b.Length)) > 0)
                {
                    Console.WriteLine(temp.GetString(b, 0, readLen));
                }
            }


            Console.WriteLine("Stream Writer/ Reader class "); // mostly used
            // The StreamWriter and StreamReader classes are useful whenever you need to read or write characterbased data (e.g., strings). 

            // Writing to the file 
            string str;
            FileStream fout;

            fout = new FileStream(@"C:\Users\proir\Desktop\Training\Day01\FileHandling\test.txt", FileMode.Create, FileAccess.Write);

            StreamWriter fstr_out = new(fout);

            Console.WriteLine("Enter text ('stop' to quit).");
            do
            {
                Console.Write(": ");
                str = Console.ReadLine();

                if (str != "stop")
                {
                    str += "\r\n"; // add newline and carriage return to leftmost position

                    fstr_out.Write(str);

                }
            } 
            while (str != "stop");

            fstr_out.Close();


            // Reading from the file
            FileStream fin;
            string s;


            fin = new FileStream("test.txt", FileMode.Open, FileAccess.Read);

            StreamReader fstr_in = new StreamReader(fin);


            while ((s = fstr_in.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }

            fstr_in.Close();

        }

        private static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }

        public static void WriteDefaultValues()
        {
            using (FileStream stream = File.Open(fileName, FileMode.Create))
            {
                using (var writer = new BinaryWriter(stream, Encoding.UTF8, false))
                {
                    // discrete primitives are written to files
                    writer.Write(1.250F);
                    writer.Write(@"c:\Temp");
                    writer.Write(10);
                    writer.Write(true);
                }
            }
        }

        public static void DisplayValues()
        {
            float aspectRatio;
            string tempDirectory;
            int autoSaveTime;
            bool showStatusBar;

            if (File.Exists(fileName))
            {
                using (var stream = File.Open(fileName, FileMode.Open))
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        // discrete primitives read from files
                        aspectRatio = reader.ReadSingle();
                        tempDirectory = reader.ReadString();
                        autoSaveTime = reader.ReadInt32();
                        showStatusBar = reader.ReadBoolean();
                    }
                }

                Console.WriteLine("Aspect ratio set to: " + aspectRatio);
                Console.WriteLine("Temp directory is: " + tempDirectory);
                Console.WriteLine("Auto save time set to: " + autoSaveTime);
                Console.WriteLine("Show status bar: " + showStatusBar);
            }
        }
    }
}
