﻿using System;
using log4net.Core;
using System.Diagnostics;


namespace PACommon.Log
{
    struct LogItem
    {
        public string msg;
        public DateTime dt;
        public StackFrame sf;
        public Level lv;
        public Exception ex;
        public string StackFile;

        public LogItem(string message, StackFrame stackFrame, Level level, Exception exception, string stackFile)
        {
            msg = message;
            dt = DateTime.Now;
            sf = stackFrame;
            lv = level;
            ex = exception;
            StackFile = stackFile;
        }
    }
}
