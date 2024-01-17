using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACommon.Log
{
    public interface ICommonLog
    {
        void Info(string message, string stackFile);
        void Warning(string message, string stackFile);
        void Error(string message, string stackFile);

        void Warning(string message, Exception ex, string stackFile);
        void Error(string message, Exception ex, string stackFile);
    }
}
