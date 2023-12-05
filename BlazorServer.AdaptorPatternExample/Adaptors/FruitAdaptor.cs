using BlazorServer.AdaptorPatternExample.Domain.Etities;
using BlazorServer.AdaptorPatternExample.Domain.Models;

namespace BlazorServer.AdaptorPatternExample.Adaptors
{
    public class FruitAdaptor : IFruitAdaptor
    {
        public FruityViceFruit? FruityFruit { get; set; }

        public FruitAdaptor(FruityViceFruit fruityViceFruit)
        {
            FruityFruit = fruityViceFruit;
        }
        public Fruit GetFruit()
        {
            if (FruityFruit == null)
            {
                return new Fruit();
            }

            if (FruityFruit.nutritions == null)
            {
                return new Fruit();
            }

            return new Fruit { 
                ExternalId = (int)FruityFruit.id!, 
                RquestedDate = DateTime.Now, 
                Calories = FruityFruit.nutritions!.calories, 
                Carbohydrates = FruityFruit.nutritions!.carbohydrates,
                Protein = FruityFruit.nutritions!.protein,
                Sugar = FruityFruit.nutritions!.sugar,
                Fat = FruityFruit.nutritions!.fat,
                Family = FruityFruit?.family,
                Genus = FruityFruit?.genus,
                Order = FruityFruit?.order,
                Name = FruityFruit?.name,
                Description = FruityFruit?.name
            };
        }
    }
}
