using Dine.DataModel.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.GQLTypes.QueryType
{
    public class PaymentType : ObjectGraphType<Payment>
    {
        public PaymentType() {
            Field(m  => m.PaymentId);
            Field(m => m.UserId);
            Field(m => m.RestaurantId);
            Field(m => m.OrderId);
            Field(m => m.ReservationId);
            Field(m => m.Amount);
            Field(m => m.Currency);
            Field(m => m.Success);
            Field(m => m.CreatedAt);
            Field(m => m.PaymentTime);
        }
    }
}
