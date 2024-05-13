using BlazorApp1.Server.Services;
using BlazorApp1.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClubController : ControllerBase
    {
        private readonly IClubService _clubService;

        public ClubController(IClubService clubService)
        {
            _clubService = clubService;
        }

        [HttpGet("GetOneClub/{id}")]
        public async Task<Club> GetClubAsync(int id)
        {
            return await _clubService.GetOneClubAsync(id);
        }
    }
}
