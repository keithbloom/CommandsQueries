using System;
using System.IO;
using CommandsQueries.Contracts;
using Xunit;

namespace CommandsQueries.Tests
{
    public class CommandTest
    {
        [Fact]
        public void RunACommand()
        {
            var bootstrapper = new Bootstrapper();

            bootstrapper.Boot();

            var container = bootstrapper.GetContainer();

            container.Configure(c => c.For<TextWriter>().Use(Console.Out));

            var test = new AddContractToCompanyCommand
                {
                    CompanyId = 1,
                    Title = "Test Contract",
                    StartDate = DateTime.Now
                };

            var mediator = container.GetInstance<IMediator>();

            mediator.Send(test);
        }
    }
}