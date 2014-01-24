namespace CommandsQueries
{
    public interface IMediator
    {
        Response<TResponseData> Send<TResponseData>(ICommand<TResponseData> command);
    }
}