using System;
using System.Collections.Generic;
using System.Text;

namespace Silverdawn.Exceptions
{
    public interface ILogExceptions
    {
        void Log( LogLevel level, Exception ex, string message = "");
        void Log( LogLevel level, string message);
    }

    public enum LogLevel
    {
        Error,
        Warn,
        Info,
        Debug
    }
}
