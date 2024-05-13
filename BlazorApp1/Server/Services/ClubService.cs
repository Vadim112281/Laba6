using BlazorApp1.Server.Data;
using BlazorApp1.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.Xml;

namespace BlazorApp1.Server.Services
{
    public class ClubService: IClubService
    {
        private readonly AppDbContext _context;

        public ClubService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Club> GetOneClubAsync(int id)
        {
            var club = await _context.Clubs.FirstOrDefaultAsync(x => x.TeamId == id);

            if(club is not null)
            {
                return club;
            }
            else
            {
                return new Club();
            }
        }
    }
}
