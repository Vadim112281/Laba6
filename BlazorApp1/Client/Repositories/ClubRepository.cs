using BlazorApp1.Shared.Models;
using System.Net.Http.Json;
using System.Net;

namespace BlazorApp1.Client.Repositories
{
    public class ClubRepository : IClubRepository
    {
        private readonly HttpClient _httpClient;

        public ClubRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Club?> GetOneClubAsync(int id)
        {
            var result = await _httpClient.GetAsync($"api/Club/GetOneClub/{id}");
            if (result.StatusCode == HttpStatusCode.OK)
            {
                return await result.Content.ReadFromJsonAsync<Club?>();
            }
            return null;
        }
    }
}
