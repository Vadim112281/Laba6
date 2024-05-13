using BlazorApp1.Shared.Models;

namespace BlazorApp1.Client.Repositories
{
    public interface IClubRepository
    {
        Task<Club?> GetOneClubAsync(int id);
    }
}
