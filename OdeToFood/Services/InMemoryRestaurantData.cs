using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                 new Restaurant { Id = 1, Name = "Pizza place" },
                 new Restaurant { Id = 2, Name = "Sushi place" },
                 new Restaurant { Id = 3, Name = "Ramen place" },
            };
        }

    List<Restaurant> _restaurants;

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Name);
        }
    }
}
        
       

