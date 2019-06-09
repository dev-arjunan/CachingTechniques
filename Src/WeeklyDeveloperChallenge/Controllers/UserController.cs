using System.Web.Mvc;
using WeeklyDeveloperChallenge.Caching.Interfaces;
using WeeklyDeveloperChallenge.Models;
using WeeklyDeveloperChallenge.Repositories.Interfaces;

namespace WeeklyDeveloperChallenge.Controllers
{
    public class UserController : Controller
    {
        private IUserRepository _userRepo;
        private ICacheStorage _cache;
        public UserController(IUserRepository userRepo, ICacheStorage cache)
        {
            _userRepo = userRepo;
            _cache = cache;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetUserById(int id)
        {
            User user = null;
            string storageKey = string.Format("user_id_{0}", id);
            user = _cache.Retrieve<User>(storageKey);

            if (user == null)
            {
                user = _userRepo.GetUserById(id);
                _cache.Store(storageKey, user);
            }

            return View(user); ;
        }
    }
}
