using BlazorServer.AdaptorPatternExample.Domain.Models;

namespace BlazorServer.AdaptorPatternExample.Repositories
{
    public interface IRepositoryBase<T> where T : BaseModel
    {
        T Add(T entity);

        IEnumerable<T> GetAll();

        T? GetById(int id);
    }
}
