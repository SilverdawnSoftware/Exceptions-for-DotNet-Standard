using System;
using System.Collections.Generic;
using System.Text;
using Exceptionless;
using Exceptionless.Models;

namespace Silverdawn.Exceptions
{
    public class ExceptionlessLogger : ILogExceptions
    {
        public void Log(LogLevel level, Exception ex, string message = "")
        {

            switch (level)
            {
                case LogLevel.Error:
                    ExceptionlessClient.Default.SubmitException(ex);
                    break;
                case LogLevel.Warn:
                    ExceptionlessClient.Default.SubmitEvent(new Event { Message = message});
                    break;
                case LogLevel.Info:
                    ExceptionlessClient.Default.SubmitEvent(new Event { Message = message});
                    break;
                case LogLevel.Debug:
                    ExceptionlessClient.Default.SubmitLog(message);
                    break;                   
            }

           
        }

        public void Log(LogLevel level, string message)
        {
            Log(level,null,message);
        }
    }
}
