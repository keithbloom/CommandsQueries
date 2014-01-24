namespace CommandsQueries
{
    public interface IMediator
    {
        Response<TResponseData> Request<TResponseData>(IQuery<TResponseData> query);
        Response<TResponseData> Send<TResponseData>(ICommand<TResponseData> command);
    }
}