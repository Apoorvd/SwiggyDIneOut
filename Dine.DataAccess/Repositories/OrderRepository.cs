using Dine.Service.Contracts;
using Dine.DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.Service.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public bool CancelOrder(int orderId)
        {
            throw new NotImplementedException();
        }

        public List<Order> GeAllOrderbyUser(long userId)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAllOrderbyRestaurant(int restaurantId)
        {
            throw new NotImplementedException();
        }

        public Order GetOrderbyID(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
