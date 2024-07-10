using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Logger
{
    public class FileLogger : ILogger
    {
        public FileLogger() 
        {
            Console.WriteLine("File Logger in use!");
        }
        public bool WriteLogs(string message)
        {
            Console.WriteLine("Succesfully Uploaded!"+message);
            return true;
        }
    }
}
