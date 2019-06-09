using WeeklyDeveloperChallenge.Repositories.Interfaces;
using WeeklyDeveloperChallenge.Models;
using System.Net;
using Newtonsoft.Json;
using WeeklyDeveloperChallenge.Caching;


namespace WeeklyDeveloperChallenge.Repositories
{
    public class UserRepository : IUserRepository
    {
        public User GetUserById(int id)
        {
            using (var client = new WebClient())
            {
                var userJson = client.DownloadString("https://swapi.co/api/people/" + id.ToString());
                var user = JsonConvert.DeserializeObject<User>(userJson);
        
                return user;
            }
        }
    }
}