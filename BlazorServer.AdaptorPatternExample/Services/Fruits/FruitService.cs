using BlazorServer.AdaptorPatternExample.Adaptors;
using BlazorServer.AdaptorPatternExample.Domain.Etities;
using BlazorServer.AdaptorPatternExample.Domain.Models;
using BlazorServer.AdaptorPatternExample.Repositories;
using BlazorServer.AdaptorPatternExample.Repositories.Fruits;
using BlazorServer.AdaptorPatternExample.Services.FruityViceServices;

namespace BlazorServer.AdaptorPatternExample.Services.Fruits
{
    public class FruitService : ServiceBase<Fruit, IFruitRepository>, IFruitService
    {
        private readonly IFruityViceService<FruityViceFruit> FruityViceService;
        public FruitService(IRepositoryBase<Fruit> repo, IFruityViceService<FruityViceFruit> fruityViceService) : base(repo)
        {
            FruityViceService = fruityViceService;
        }

        public async Task<Fruit> AddFromFruityVice(string fruit)
        {
            Fruit NewFruit = new Fruit();
            
            var fruityFruit = await FruityViceService.GetFruitByName(fruit.ToLower());
            FruitAdaptor FruitAdaptor= new FruitAdaptor(fruityFruit);

            NewFruit = FruitAdaptor.GetFruit();

            if (String.IsNullOrEmpty(NewFruit.Name)) 
            {
                return new Fruit();
            }

            return Repo.Add(NewFruit);
        }
    }
}
