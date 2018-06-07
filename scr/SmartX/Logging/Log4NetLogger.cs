﻿using log4net;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartX.Logging
{
    public class Log4NetLogger : ILogger
    {
        private readonly ILog _log;

        public Log4NetLogger()
        {
            _log = LogManager.GetLogger("smartx", "log4net");
        }

        #region ILogger Members

        public bool IsDebugEnabled
        {
            get { return _log.IsDebugEnabled; }
        }
        public void Debug(string message)
        {
            _log.Debug(message);
        }
        public void DebugFormat(string format, params object[] args)
        {
            _log.DebugFormat(format, args);
        }
        public void Debug(string message, Exception exception)
        {
            _log.Debug(message, exception);
        }
        public void Info(string message)
        {
            _log.Info(message);
        }
        public void InfoFormat(string format, params object[] args)
        {
            _log.InfoFormat(format, args);
        }
        public void Info(string message, Exception exception)
        {
            _log.Info(message, exception);
        }
        public void Error(string message)
        {
            _log.Error(message);
        }
        public void ErrorFormat(string format, params object[] args)
        {
            _log.ErrorFormat(format, args);
        }
        public void Error(string message, Exception exception)
        {
            _log.Error(message, exception);
        }
        public void Warn(string message)
        {
            _log.Warn(message);
        }
        public void WarnFormat(string format, params object[] args)
        {
            _log.WarnFormat(format, args);
        }
        public void Warn(string message, Exception exception)
        {
            _log.Warn(message, exception);
        }
        public void Fatal(string message)
        {
            _log.Fatal(message);
        }
        public void FatalFormat(string format, params object[] args)
        {
            _log.FatalFormat(format, args);
        }
        public void Fatal(string message, Exception exception)
        {
            _log.Fatal(message, exception);
        }

        #endregion
    }
}
