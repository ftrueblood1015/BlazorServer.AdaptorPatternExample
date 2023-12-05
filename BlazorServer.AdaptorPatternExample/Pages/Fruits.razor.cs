using BlazorServer.AdaptorPatternExample.Domain.Models;
using BlazorServer.AdaptorPatternExample.Services.Fruits;
using Microsoft.AspNetCore.Components;

namespace BlazorServer.AdaptorPatternExample.Pages
{
    public partial class Fruits
    {
        [Inject]
        private NavigationManager? NavManager { get; set; }

        [Inject]
        IFruitService? FruitService { get; set; }

        private List<Fruit>? FruitList { get; set; }

        private string? SearchString { get; set; }

        protected override async Task OnInitializedAsync()
        {
            if (FruitService == null)
            {
                throw new ArgumentException(nameof(FruitService));
            }

            var Response = FruitService.GetAll();
            FruitList = Response != null ? Response.ToList() : new List<Fruit>();
        }

        private Func<Fruit, bool> QuickFilter => x =>
        {
            if (string.IsNullOrWhiteSpace(SearchString))
                return true;

            if (x.Name!.Contains(SearchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if (x.Order!.Contains(SearchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if (x.Genus!.Contains(SearchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if (x.Family!.Contains(SearchString, StringComparison.OrdinalIgnoreCase))
                return true;

            return false;
        };

        public void LookUpFruit()
        {
            if (NavManager != null)
            {
                NavManager.NavigateTo("/newfruit");
            }
        }
    }
}
