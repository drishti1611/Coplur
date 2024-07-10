using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Logger
{
    public interface ILogger
    {
        bool WriteLogs(string message);

    }
}
