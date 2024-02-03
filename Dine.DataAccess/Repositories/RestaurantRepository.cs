using Dine.DataAccess.Contracts;
using Dine.DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.DataAccess.Repositories
{
    public class RestaurantRepository : IRestaurantRepository
    {
        public bool AddRestaurant(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRestaurant(int id)
        {
            throw new NotImplementedException();
        }

        public List<Restaurant> GetAllRestaurants()
        {
            throw new NotImplementedException();
        }

        public Restaurant GetRestaurant(int id)
        {
            throw new NotImplementedException();
        }

        public List<Restaurant> SearchRestaurant(string criteria)
        {
            throw new NotImplementedException();
        }

        public bool UpdateRestaurant(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }
    }
}
