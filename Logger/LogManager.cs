using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger.Logger;

namespace Logger
{
    public class LogManager
    {
        ILogger _logger=null;

        public LogManager(ILogger basename)
        { 
            _logger = basename; 
        }  
        public bool WriteLogs(string message)
        {
            return _logger.WriteLogs(message);
        }
    }
}
