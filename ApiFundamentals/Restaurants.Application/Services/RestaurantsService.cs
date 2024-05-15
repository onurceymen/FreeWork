using Microsoft.Extensions.Logging;
using Restaurants.Domain.Entity;
using Restaurants.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Application.Services
{
    internal class RestaurantsService(IRestaurantsRepository restaurantsRepository,
    ILogger<RestaurantsService> logger) : IRestaurantsService
    {
        public async Task<IEnumerable<Restaurant>> GetAllRestaurants()
        {
            logger.LogInformation("Getting all restaurants");
            var restaurants = await restaurantsRepository.GetAllAsync();
            return restaurants;
        }

        public async Task<Restaurant?> GetById(int id)
        {
            logger.LogInformation($"Getting restaurant {id}");
            var restaurant = await restaurantsRepository.GetByIdAsync(id);

            return restaurant;

        }
    }
}
