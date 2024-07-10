using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Logger
{
    public class DataBaseLogger : ILogger
    {
        public DataBaseLogger() 
        {
            Console.WriteLine("DataBase Logger in use!");
        } 
        public bool WriteLogs(string message)
        {
            Console.WriteLine("Successfully uploaded!"+message);
            return true;
        }
    }
}
