using System.Linq;

namespace CommandsQueries
{
    public interface IRepository<T>
    {
        IQueryable<T> All();
        void Add(T entity);
        void SaveChanges();
    }
}