namespace CommandsQueries
{
    public interface ICommand { }

    public interface ICommand<out TResult> : ICommand { }

    public interface ICommandHandler<in TCommand, out TResult>
    {
        TResult Handle(TCommand command);
    }

    public interface ICommandHandler<in TCommand> : ICommandHandler<TCommand, UnitType> { }
}