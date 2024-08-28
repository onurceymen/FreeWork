using Microsoft.AspNetCore.Mvc;
using UserMVC.Models;
using UserMVC.Services;

namespace UserMVC.Controllers
{
    public class UserController : Controller
    {
        private readonly UserApiService _userApiService;

        public UserController(UserApiService userApiService)
        {
            _userApiService = userApiService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(User user)
        {
            await _userApiService.AddUserAsync(user);
            return RedirectToAction("Index");
        }

    }
}
