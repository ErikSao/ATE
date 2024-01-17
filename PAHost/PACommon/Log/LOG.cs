
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;


namespace PACommon.Log
{
    public static class LOG
    {
        public static ICommonLog InnerLogger { set; private get; }

        static string GetFormatStackFrameInfo(int traceLevel)
        {
            try
            {
                StackFrame sf = new StackTrace(true).GetFrame(traceLevel + 1);
                if (sf == null)
                {
                    return "stack frame is null";
                }
                string pathFile = sf.GetFileName();
                string file = string.IsNullOrEmpty(pathFile) ? "" : pathFile.Substring(pathFile.LastIndexOf('\\') + 1);
                return $"{file}\tLine {sf.GetFileLineNumber()}\t{sf.GetMethod().Name}()";
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static void Info(string message, int traceLevel = 2, [CallerFilePath] string file = "",
            [CallerMemberName] string member = "",
            [CallerLineNumber] int line = 0)
        {
            if (InnerLogger != null)
                InnerLogger.Info(message, GetFormatStackFrameInfo(traceLevel));
        }

        public static void Warning(string message, int traceLevel = 2, [CallerFilePath] string file = "",
            [CallerMemberName] string member = "",
            [CallerLineNumber] int line = 0)
        {
            if (InnerLogger != null)
                InnerLogger.Warning(message, GetFormatStackFrameInfo(traceLevel));
        }

        public static void Warning(string message, int traceLevel = 2, [CallerFilePath] string file = "",
            [CallerMemberName] string member = "",
            [CallerLineNumber] int line = 0, params object[] args)
        {
            if (InnerLogger != null)
                InnerLogger.Warning(string.Format(message, args), GetFormatStackFrameInfo(traceLevel));
        }

        public static void Warning(string message, Exception ex, int traceLevel = 2, [CallerFilePath] string file = "",
            [CallerMemberName] string member = "",
            [CallerLineNumber] int line = 0)
        {
            if (InnerLogger != null)
                InnerLogger.Warning(message, ex, GetFormatStackFrameInfo(traceLevel));
        }

        public static void Error(string message, int traceLevel = 2, [CallerFilePath] string file = "",
            [CallerMemberName] string member = "",
            [CallerLineNumber] int line = 0)
        {
            if (InnerLogger != null)
                InnerLogger.Error(message, GetFormatStackFrameInfo(traceLevel));
        }
        public static void Error(string message, Exception ex, int traceLevel = 2, [CallerFilePath] string file = "",
            [CallerMemberName] string member = "",
            [CallerLineNumber] int line = 0)
        {
            if (InnerLogger != null)
                InnerLogger.Error(message, ex, GetFormatStackFrameInfo(traceLevel));
        }

        public static void Write(Exception ex, int traceLevel = 2, [CallerFilePath] string file = "",
            [CallerMemberName] string member = "",
            [CallerLineNumber] int line = 0)
        {
            Error("", ex, traceLevel + 1);
        }

        public static void Write(string message, Exception ex,  int traceLevel = 2, [CallerFilePath] string file = "", 
            [CallerMemberName] string member = "", 
            [CallerLineNumber] int line = 0)
        {
            Error(message, ex, traceLevel + 1);
        }

        public static void Write(string message, int traceLevel = 2, [CallerFilePath] string file = "", 
            [CallerMemberName] string member = "", 
            [CallerLineNumber] int line = 0)
        {
            Info(message, traceLevel + 1);
        }
    }
}
