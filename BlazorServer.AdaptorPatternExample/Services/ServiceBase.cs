using BlazorServer.AdaptorPatternExample.Domain.Models;
using BlazorServer.AdaptorPatternExample.Repositories;

namespace BlazorServer.AdaptorPatternExample.Services
{
    public class ServiceBase<T, TRepo> : IServiceBase<T>
        where TRepo : IRepositoryBase<T>
        where T : BaseModel
    {
        protected IRepositoryBase<T> Repo { get; }
        public ServiceBase(IRepositoryBase<T> repo)
        {
            Repo = repo;
        }

        public T Add(T entity)
        {
            return Repo.Add(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return Repo.GetAll();
        }

        public T? GetById(int id)
        {
            return Repo.GetById(id);
        }
    }
}
