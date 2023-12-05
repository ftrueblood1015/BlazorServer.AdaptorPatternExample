using BlazorServer.AdaptorPatternExample.Domain.Models;
using BlazorServer.AdaptorPatternExample.Infrastructure;

namespace BlazorServer.AdaptorPatternExample.Repositories.Fruits
{
    public class FruitRepository : RepositoryBase<Fruit, AdaptorPatternExampleContext>, IFruitRepository
    {
        public FruitRepository(AdaptorPatternExampleContext context) : base(context)
        {
        }
    }
}
