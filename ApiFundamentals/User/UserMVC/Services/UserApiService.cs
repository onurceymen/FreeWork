using UserMVC.Models;

namespace UserMVC.Services
{
    public class UserApiService
    {
        private readonly UserApiClient _userApiClient = new();

        public Task<User?> AddUserAsync(User user)
        {
            return _userApiClient.AddUserAsync(user);
        }
    }
}
