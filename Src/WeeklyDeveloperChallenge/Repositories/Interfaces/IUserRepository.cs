using WeeklyDeveloperChallenge.Models;

namespace WeeklyDeveloperChallenge.Repositories.Interfaces
{
    public interface IUserRepository
    {
        User GetUserById(int id);
    }
}
