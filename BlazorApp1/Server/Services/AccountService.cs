using BlazorApp1.Server.Data;
using BlazorApp1.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Server.Services
{
    public class AccountService : IAccountService
    {
        private readonly AppDbContext _appDbContext;

        public AccountService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Account> FindAccountByNameAsync(string login)
        {
            var account = await _appDbContext.Accounts.FirstOrDefaultAsync(x => x.Login == login);
            if (account is not null) 
            {
                return account;
            }
            else
            {
                return new Account();
            }
        }   
    }
}
