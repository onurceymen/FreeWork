using Restaurants.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Application.Services
{
    public interface IRestaurantsService
    {
        Task<IEnumerable<Restaurant>> GetAllRestaurants();
        Task<Restaurant?> GetById(int id);
    }
}
