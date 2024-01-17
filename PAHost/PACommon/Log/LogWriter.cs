using log4net.Core;
using System;
using System.Reflection;


namespace PACommon.Log
{
    class LogWriter
    {
        private readonly static Type ThisDeclaringType = typeof(LogWriter);
        private readonly ILogger defaultLogger;
        public LogWriter()
        {
            defaultLogger = LoggerManager.GetLogger(Assembly.GetExecutingAssembly(), "CommonLogger");
        }

        string FormatLogString(LogItem logItem)
        {
            string result = logItem.msg;
            try
            {
                result = string.Format("{0}\t{1}\t{2} ", logItem.dt.ToString("yyyy/MM/dd HH:mm:ss.fff"),
                    logItem.lv.Name,
                    logItem.msg);
            }
            catch (Exception)
            {
                result = "";
            }

            return result;
        }

        public string Write(LogItem logItem)
        {
            string log = FormatLogString(logItem);
            if (defaultLogger.IsEnabledFor(logItem.lv))
            {
                defaultLogger.Log(typeof(LogWriter), logItem.lv, log, logItem.ex);
            }
            return log;
        }

        public void Shutdown()
        {
            defaultLogger.Repository.Shutdown();
        }
    }
}
