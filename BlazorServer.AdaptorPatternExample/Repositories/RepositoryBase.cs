using BlazorServer.AdaptorPatternExample.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace BlazorServer.AdaptorPatternExample.Repositories
{
    public class RepositoryBase<T, TContext> : IRepositoryBase<T>
        where T : BaseModel
        where TContext : DbContext
    {
        public TContext Context { get; private set; }
        public RepositoryBase(TContext context)
        {
            Context = context;
        }

        public T Add(T entity)
        {
            _ = Context.Set<T>().Add(entity);

            Context.SaveChanges();

            return GetById(entity.Id.GetValueOrDefault())!;
        }

        public IEnumerable<T> GetAll()
        {
            var result = Context.Set<T>();
            return result;
        }

        public T? GetById(int id)
        {
            return Context.Set<T>().FirstOrDefault(x => x.Id == id);
        }
    }
}
