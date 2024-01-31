using Dine.DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.DataAccess.Contracts
{
    public interface IOrderRepository
    {
        Order GetOrderbyID(int id);
        List<Order> GeAllOrderbyUser(long userId);
        List<Order> GetAllOrderbyRestaurant(int restaurantId);
        bool UpdateOrder(Order order);
        bool CancelOrder(int  orderId);

    }
}
