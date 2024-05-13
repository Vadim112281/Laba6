using BlazorApp1.Server.Services;
using BlazorApp1.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet("{login}")]
        public async Task<Account> FindByLoginAsync(string login)
        {
            var account = await _accountService.FindAccountByNameAsync(login);

            return account;
        }
    }
}
