using Dine.DataModel.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.GQLTypes.QueryType
{
    public class ReviewType : ObjectGraphType<Review>
    {
        public ReviewType() {
            Field(m => m.Id);
            Field(m => m.UserId);
            Field(m => m.MenuId);
            Field(m => m.RestaurantId);
            Field(m => m.ReviewTitle);
            Field(m => m.ReviewText);
            Field(m => m.ReviewStar);
        }
    }
}
