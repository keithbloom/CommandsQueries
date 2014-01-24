namespace CommandsQueries
{
    public interface ICommand<out TResult> : ICommand
    {

    }

    public interface ICommand { }
}