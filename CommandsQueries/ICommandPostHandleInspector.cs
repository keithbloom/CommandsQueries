namespace CommandsQueries
{
    public interface ICommandPostHandleInspector
    {
        bool InterestedIn(ICommand command);

        void Inspect(ICommand command);
    }
}