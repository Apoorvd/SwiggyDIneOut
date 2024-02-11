using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.GQLTypes.QueryType
{
    public class UserInputType : InputObjectGraphType
    {
        public UserInputType() {
            Field<NonNullGraphType<IntGraphType>>("userId");
            Field<StringGraphType>("fName");
            Field<StringGraphType>("lName");
            Field<StringGraphType>("emailId");
            Field<StringGraphType>("phoneNumber");
            Field<StringGraphType>("password");
            Field<DateGraphType>("birthDay");
            Field<DateGraphType>("dateCreated");
            Field<DateGraphType>("dateUpdated");

        }
    }
}
