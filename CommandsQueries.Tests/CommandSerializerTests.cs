using System;
using System.IO;
using Xunit;

namespace CommandsQueries.Tests
{
    public class CommandSerializerTests
    {
        [Fact]
        public void WillSerializeCommands()
        {
            var command = new DoSomethingCommand
                {
                    Name = "Test",
                    NumberOfTimes = 1
                };


            var builder = new StringWriter();
            var sut = new JsonCommandSerializer(builder);

            sut.Inspect(command);

            Console.WriteLine(builder);
        }
    }
}