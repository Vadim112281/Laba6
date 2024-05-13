using BlazorApp1.Shared.Models;

namespace BlazorApp1.Server.Services
{
    public interface IAccountService
    {
        Task<Account> FindAccountByNameAsync(string login);
    }
}
