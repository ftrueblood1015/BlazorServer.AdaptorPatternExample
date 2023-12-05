using BlazorServer.AdaptorPatternExample.Domain.Models;

namespace BlazorServer.AdaptorPatternExample.Services.Fruits
{
    public interface IFruitService : IServiceBase<Fruit>
    {
        public Task<Fruit> AddFromFruityVice(string fruit);
    }
}
