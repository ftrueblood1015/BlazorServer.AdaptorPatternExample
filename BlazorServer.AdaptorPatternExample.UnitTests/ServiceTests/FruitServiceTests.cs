using BlazorServer.AdaptorPatternExample.Domain.Etities;
using BlazorServer.AdaptorPatternExample.Domain.Models;
using BlazorServer.AdaptorPatternExample.Repositories.Fruits;
using BlazorServer.AdaptorPatternExample.Services.Fruits;
using BlazorServer.AdaptorPatternExample.Services.FruityViceServices;
using BlazorServer.AdaptorPatternExample.UnitTests.BaseMocks;
using Moq;
using Shouldly;

namespace BlazorServer.AdaptorPatternExample.UnitTests.ServiceTests
{
    internal class FruitServiceTests
    {
        private readonly FruitService FruitService;

        public FruitServiceTests()
        {
            var FruitRepo = MockRepoBase.MockRepo<IFruitRepository, Fruit>(new List<Fruit>()
                {
                    new Fruit { Id = 1, Calories = 96, Carbohydrates = 22, Description = "Banana", ExternalId = 2, Family = "Musaceae", Fat = 0.2,
                    Genus = "Musa", Name = "Banana", Order = "Zingiberales", Protein = 0, RquestedDate = DateTime.Now, Sugar = 17.2 }
                }
            );

            var FruityViceService = new Mock<IFruityViceService<FruityViceFruit>>();

            var FruityViceFruitList = new List<FruityViceFruit>() {
                        new FruityViceFruit { id = 52, name = "persimmon", family = "Ebenaceae", order = "Rosales", genus = "Diospyros",
                            nutritions = new FruityViceNutrition { protein = 0, fat = 0, calories = 81, carbohydrates = 18, sugar = 18} },
                        new FruityViceFruit { id = 1, name = "banana", family = "Musaceae", order = "Zingiberales", genus = "Musa",
                            nutritions = new FruityViceNutrition { protein = 1, fat = 0.2, calories = 96, carbohydrates = 22, sugar = 17.2} }
                    };

            FruityViceService.Setup(x => x.GetFruitByName(It.IsAny<string>())).Returns((string x) => 
            {
                return Task.FromResult(FruityViceFruitList.FirstOrDefault(y => y.name == x)!);
            });

            FruitService = new FruitService(FruitRepo.Object, FruityViceService.Object);
        }

        [Test]
        public void CanAddBanana()
        {
            var result = FruitService.AddFromFruityVice("Banana");

            result.Result.Name.ShouldBe("banana");
        }

        [Test]
        public void CanAddBananaWithCorrectFat()
        {
            var result = FruitService.AddFromFruityVice("Banana");

            result.Result.Fat.ShouldBe(0.2);
        }

        [Test]
        public void CanAddBananaWithCorrectProtein()
        {
            var result = FruitService.AddFromFruityVice("Banana");

            result.Result.Protein.ShouldBe(1);
        }

        [Test]
        public void CanAddBananaWithCorrectCalories()
        {
            var result = FruitService.AddFromFruityVice("Banana");

            result.Result.Calories.ShouldBe(96);
        }

        [Test]
        public void CanAddBananaWithCorrectCarbs()
        {
            var result = FruitService.AddFromFruityVice("Banana");

            result.Result.Carbohydrates.ShouldBe(22);
        }

        [Test]
        public void CanAddBananaWithCorrectSugar()
        {
            var result = FruitService.AddFromFruityVice("Banana");

            result.Result.Sugar.ShouldBe(17.2);
        }

        [Test]
        public void CanAddPersimmon()
        {
            var result = FruitService.AddFromFruityVice("Persimmon");

            result.Result.Name.ShouldBe("persimmon");
        }

        [Test]
        public void CanAddPersimmonWithCorrectFat()
        {
            var result = FruitService.AddFromFruityVice("Persimmon");

            result.Result.Fat.ShouldBe(0);
        }

        [Test]
        public void CanAddPersimmonWithCorrectProtein()
        {
            var result = FruitService.AddFromFruityVice("Persimmon");

            result.Result.Protein.ShouldBe(0);
        }

        [Test]
        public void CanAddPersimmonWithCorrectCalories()
        {
            var result = FruitService.AddFromFruityVice("Persimmon");

            result.Result.Calories.ShouldBe(81);
        }

        [Test]
        public void CanAddPersimmonWithCorrectCarbs()
        {
            var result = FruitService.AddFromFruityVice("Persimmon");

            result.Result.Carbohydrates.ShouldBe(18);
        }

        [Test]
        public void CanAddPersimmonWithCorrectSugar()
        {
            var result = FruitService.AddFromFruityVice("Persimmon");

            result.Result.Sugar.ShouldBe(18);
        }

        [Test]
        public void AddCherryShouldBeNull()
        {
            var result = FruitService.AddFromFruityVice("Cherry");

            result.Result.Name.ShouldBe(null);
        }
    }
}
