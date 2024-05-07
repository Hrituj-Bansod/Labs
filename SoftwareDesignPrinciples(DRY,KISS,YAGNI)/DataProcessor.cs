using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPrinciples_DRY_KISS_YAGNI_
{
    // Without YAGNI
    public interface IDataRepository
    {
        void SaveData(string data);
    }

    public class SqlDataRepository : IDataRepository
    {
        public void SaveData(string data)
        {
            // Save data to SQL database
            Console.WriteLine("Data saved to SQL database: " + data);
        }
    }

    // With YAGNI
    public class DataProcessor
    {
        public void ProcessData(string data)
        {
            // Process data without unnecessary abstraction
            Console.WriteLine("Data processed: " + data);
        }
    }
}
