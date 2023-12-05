
using BlazorServer.AdaptorPatternExample.Domain.Models;

namespace BlazorServer.AdaptorPatternExample.Services
{
    public interface IServiceBase<T> where T : BaseModel
    {
        T Add(T entity);

        IEnumerable<T> GetAll();

        T? GetById(int id);
    }
}
