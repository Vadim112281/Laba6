using BlazorApp1.Shared.Models;

namespace BlazorApp1.Server.Services
{
    public interface IClubService
    {
        Task<Club> GetOneClubAsync(int id);
    }
}
