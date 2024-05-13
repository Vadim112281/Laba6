using BlazorApp1.Shared.Models;

namespace BlazorApp1.Client.Repositories
{
    public interface IAccountRepository
    {
        Task<Account?> GetAccoundByLoginAsync(string login); 
    }
}
