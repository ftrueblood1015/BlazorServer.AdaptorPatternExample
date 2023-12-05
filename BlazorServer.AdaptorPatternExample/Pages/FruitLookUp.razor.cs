using BlazorServer.AdaptorPatternExample.Domain.Models;
using BlazorServer.AdaptorPatternExample.Services.Fruits;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace BlazorServer.AdaptorPatternExample.Pages
{
    public partial class FruitLookUp
    {
        [Inject]
        private NavigationManager? NavManager { get; set; }

        [Inject]
        private IFruitService? FruitService { get; set; }

        private string? LookUpString { get; set; }

        Fruit? NewFruit { get; set; }

        bool success;

        string[] errors = { };

        MudForm? Form;

        protected override async Task OnInitializedAsync()
        {
            NewFruit = new Fruit();
        }

        private void CancelClick()
        {
            if (NavManager != null)
            {
                NavManager.NavigateTo("/fruits");
            }
        }

        private async void Save()
        {
            await Form!.Validate();

            if (FruitService == null)
            {
                throw new ArgumentNullException(nameof(FruitService));
            }

            if (Form.IsValid && !String.IsNullOrWhiteSpace(LookUpString))
            {
                NewFruit = await FruitService.AddFromFruityVice(LookUpString!);
            }

            StateHasChanged();
        }
    }
}
