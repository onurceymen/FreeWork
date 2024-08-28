using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Restaurants.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Application.Restaurants.Commands.UpdateRestaurant
{
    public class UpdateRestaurantCommandHandler(ILogger<UpdateRestaurantCommandHandler> logger,
        IRestaurantsRepository restaurantsRepository,
        IMapper mapper) : IRequestHandler<UpdateRestaurantCommand,bool> 
    {
        public async Task<bool> Handle(UpdateRestaurantCommand request, CancellationToken cancellationToken)
        {
            logger.LogInformation($"Updating Restaurant with id:{request.Id}");
            var restaurant = await restaurantsRepository.GetByIdAsync( request.Id );
            if (restaurant is null)
            {
                return false;
            }
            mapper.Map(request, restaurant);

            await restaurantsRepository.SaveChanges();

            return true;


        }
    }
}
