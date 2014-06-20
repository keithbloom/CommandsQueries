namespace CommandsQueries
{
    public abstract class AbstractCommmandHandler<TMessage> : ICommandHandler<TMessage, UnitType>
        where TMessage : ICommand<UnitType>
    {
        public UnitType Handle(TMessage command)
        {
            HandleCore(command);

            return UnitType.Default;
        }

        public abstract void HandleCore(TMessage command);
    }
}