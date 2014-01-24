namespace CommandsQueries
{
    public interface IMediator
    {
        TResult Send<TResult>(ICommand<TResult> command);
    }
}