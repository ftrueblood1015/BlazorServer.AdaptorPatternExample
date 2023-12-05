using BlazorServer.AdaptorPatternExample.Domain.Models;

namespace BlazorServer.AdaptorPatternExample.Adaptors
{
    public interface IFruitAdaptor
    {
        Fruit GetFruit();
    }
}
