using BlazorServer.AdaptorPatternExample.Domain.Etities;

namespace BlazorServer.AdaptorPatternExample.Services.FruityViceServices
{
    public interface IFruityViceService<T> where T : class
    {
        public Task<T> GetFruitByName(string fruit);
    }
}
