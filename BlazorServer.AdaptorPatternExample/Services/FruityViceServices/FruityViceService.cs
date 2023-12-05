using BlazorServer.AdaptorPatternExample.Domain.Etities;

namespace BlazorServer.AdaptorPatternExample.Services.FruityViceServices
{
    public class FruityViceService : IFruityViceService<FruityViceFruit>
    {
        static HttpClient? Client;
        private readonly string apiBaseUrl = "https://www.fruityvice.com/api/fruit/";

        public FruityViceService()
        {
            Client = new HttpClient();
        }

        public async Task<FruityViceFruit> GetFruitByName(string fruit)
        {
            if (Client == null)
            {
                Client = new HttpClient();
            }

            FruityViceFruit FruityViceFruit = new FruityViceFruit();
            HttpResponseMessage response = await Client.GetAsync($"{apiBaseUrl}{fruit}");
            if (response.IsSuccessStatusCode)
            {
                FruityViceFruit = await response.Content.ReadFromJsonAsync<FruityViceFruit>() ?? FruityViceFruit;
            }
            return FruityViceFruit;
        }
    }
}
