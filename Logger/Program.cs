using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger.Logger;

namespace Logger
{
    internal class Program
    {
        public static ILogger getLog()
        {
            string Log = "Database"; //Or Files

            if (Log == "File")
            {
                return new FileLogger();
            }
            else
            {
                return new DataBaseLogger();
            }
        }
        static void Main(string[] args)
        {
            ILogger basename = getLog();

            LogManager Manager = new LogManager(basename);
            Manager.WriteLogs(" Logging Finished!!");
            Console.ReadLine();

        }
    }
}
