using log4net.Core;
using PACommon.Utilities;
using System;
using System.Diagnostics;


namespace PACommon.Log
{
    public class LogManager : ICommonLog
    {
        PeriodicJob _loggingJob;
        FixSizeQueue<LogItem> _logQueue;
        LogWriter _writer;
        public LogManager()
        {

        }
        public void Initialize()
        {
            _logQueue = new FixSizeQueue<LogItem>(1000);
            _loggingJob = new PeriodicJob(300, this.PeriodicRun, "Save Log Job", true);
            _writer = new LogWriter();

            LOG.InnerLogger = this;
        }
        public void Terminate()
        {
            try
            {
                if (_loggingJob != null)
                {
                    _loggingJob.Stop();
                    _loggingJob = null;
                    PeriodicRun();
                    _writer.Shutdown();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex.Message);
            }
        }

        bool PeriodicRun()
        {
            LogItem item;
            while (_logQueue.TryDequeue(out item))
            {
                _writer.Write(item);
            }
            return true;
        }

        void CacheLog(string message, Level level, Exception exception, string stackFile)
        {
            _logQueue.Enqueue(new LogItem(message, new StackTrace(true).GetFrame(5), level, exception, stackFile));
        }

        public void Error(string message, string stackFile)
        {
            CacheLog(message, Level.Error, null, stackFile);
        }

        public void Error(string message, Exception ex, string stackFile)
        {
            CacheLog(message, Level.Error, ex, stackFile);
        }

        public void Info(string message, string stackFile)
        {
            CacheLog(message, Level.Info, null, stackFile);
        }

        public void Warning(string message, string stackFile)
        {
            CacheLog(message, Level.Warn, null, stackFile);
        }

        public void Warning(string message, Exception ex, string stackFile)
        {
            CacheLog(message, Level.Warn, ex, stackFile);
        }
    }
}
