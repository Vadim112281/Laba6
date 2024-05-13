using BlazorApp1.Shared.Models;
using System.Net;
using System.Net.Http.Json;

namespace BlazorApp1.Client.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly HttpClient _httpClient;

        public AccountRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Account?> GetAccoundByLoginAsync(string login)
        {
            var result = await _httpClient.GetAsync($"api/Account/{login}");
            if (result.StatusCode == HttpStatusCode.OK)
            {
                return await result.Content.ReadFromJsonAsync<Account?>();
            }
            return null;
        }
    }
}
