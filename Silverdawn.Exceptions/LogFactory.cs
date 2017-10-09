using System;
using System.Collections.Generic;
using System.Text;

namespace Silverdawn.Exceptions
{
    public class LogFactory
    {
        public static ILogExceptions GetLogger()
        {
            return new ConsoleExceptionsLogger();
        }

    }
}
