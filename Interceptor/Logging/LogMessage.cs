﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interceptor.Logging
{
    public struct LogMessage
    {
        public LogSeverity Severity { get; }
        public string Message { get; }
        public Exception Exception { get; }

        public LogMessage(LogSeverity severity, string message, Exception exception = null)
        {
            Severity = severity;
            Message = message;
            Exception = exception;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("[{0}] ", DateTime.Now);
            builder.Append(Message);
            if(Exception != null)
            {
                builder.Append(':');
                builder.AppendLine();
                builder.Append(Exception.ToString());
            }

            return builder.ToString();
        }
    }
}
