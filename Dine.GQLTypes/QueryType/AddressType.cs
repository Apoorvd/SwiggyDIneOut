using Dine.DataModel.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.GQLTypes.QueryType
{
    public class AddressType : ObjectGraphType<Address>
    {
        public AddressType() {
            Field(m => m.Id, nullable: false);
            Field(m => m.UserId);
            Field(m => m.HouseNumber);
            Field(m => m.StreetAddress);
            Field(m => m.Landmark);
            Field(m => m.PostalCode);
            Field(m => m.City);
            Field(m => m.IsDefault);

        }

    }
}
