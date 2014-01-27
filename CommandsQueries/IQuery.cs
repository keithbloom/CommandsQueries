namespace CommandsQueries
{
    public interface IQuery<T>
    {
         
    }

    public interface IQueryHandler<in TRequest, out TResult> where TRequest : IQuery<TResult>
    {
        TResult Handle(TRequest request);
    }
}