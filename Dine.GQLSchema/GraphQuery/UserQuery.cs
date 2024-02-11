using Dine.DataModel.Models;
using Dine.GQLTypes.QueryType;
using Dine.Service.Contracts;
using Dine.Service.Repositories;
using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.GQLSchema.GraphQuery
{
    public class UserQuery : ObjectGraphType
    {
        public UserQuery(IUserRepository userRepository) {
            Field<UserQType>("user")
                .Argument<NonNullGraphType<IntGraphType>>("userId", "Takes UserID as an Input")
                .ResolveAsync(async context =>
            {
                // we are using the lambda expression to call get allmenu method from this menu repository
                return await userRepository.GetUserById(context.GetArgument<int>("userId"));
            });
        }
    }
}
