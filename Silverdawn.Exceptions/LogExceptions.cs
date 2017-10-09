using System;
using System.Diagnostics;


namespace Silverdawn.Exceptions
{
   

    public class ConsoleExceptionsLogger : ILogExceptions
    {

        public void Log(LogLevel level, Exception ex, string message = "")
        {
            Console.WriteLine(level.ToString()+ ": ");
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);

        }

        public void Log(LogLevel level,string message)
        {
            Console.WriteLine(level.ToString() + ": " + message);

        }
     
    }

}
