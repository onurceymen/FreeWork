using System.Net.Http.Headers;
using System.Text;
using UserMVC.Models;
using Newtonsoft.Json;

namespace UserMVC.Services
{
    public class UserApiClient
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "http://localhost:44338"; // API adresi ve portunu buraya yazın

        public UserApiClient()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(BaseUrl);
            _httpClient.Timeout = TimeSpan.FromSeconds(120); // Örnek olarak 30 saniye olarak ayarlanmıştır
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }
        public Task<User?> AddUserAsync(User user)
        {
            string userJson = JsonConvert.SerializeObject(user);
            HttpContent content = new StringContent(userJson, Encoding.UTF8, "application/json");
            HttpResponseMessage response = _httpClient.PostAsync("/api/UserAPI/AddUser", content).Result;
            response.EnsureSuccessStatusCode();
            string responseBody = response.Content.ReadAsStringAsync().Result;
            User? addedUser = JsonConvert.DeserializeObject<User>(responseBody);
            return Task.FromResult(addedUser);
        }

    }
}
