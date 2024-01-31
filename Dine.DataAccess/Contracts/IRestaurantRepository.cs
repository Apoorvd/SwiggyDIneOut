using Dine.DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.DataAccess.Contracts
{
    public interface IRestaurantRepository
    {
        bool AddRestaurant(Restaurant restaurant);
        Restaurant GetRestaurant(int id);
        List<Restaurant> GetAllRestaurants();
        List<Restaurant> SearchRestaurant(string criteria);
        bool UpdateRestaurant(Restaurant restaurant);
        bool DeleteRestaurant(int id);
    }
}
