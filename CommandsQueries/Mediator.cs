using System.Linq;

namespace CommandsQueries
{
    public class Mediator : IMediator
    {
        private readonly ICommandPostHandleInspector[] postProcessors;

        public Mediator(ICommandPostHandleInspector[] postProcessors)
        {
            this.postProcessors = postProcessors;
        }

        public TResult Send<TResult>(ICommand<TResult> command)
        {
            // mediate
            // serialize the command;

            foreach (var processor in postProcessors.Where(x => x.InterestedIn(command)))
            {
                processor.Inspect(command);
            }

            return default(TResult);
        }
    }
}