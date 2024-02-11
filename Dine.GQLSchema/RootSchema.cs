using Dine.GQLSchema.GraphMutation;
using Dine.GQLSchema.GraphQuery;
using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.GQLSchema
{
    public class RootSchema : Schema
    {
        public RootSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<RootQuery>();
            //Mutation = serviceProvider.GetRequiredService<RootMutation>();
        }
    }
}
