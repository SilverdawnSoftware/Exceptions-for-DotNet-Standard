using System;
using Xunit;

namespace Silverdawn.Exceptions.Tests
{
    public class TestExpections
    {
        [Fact]
        public void TestInfoLog()
        {
            LogFactory.GetLogger().Log(LogLevel.Info, "hello world");

            LogFactory.GetLogger().Log(LogLevel.Error, "hello world");
        }
    }
}
