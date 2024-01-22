using Dine.DataModel.ContextModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.DataModel.ContextFactory
{
    public class DineOutGQLDbContextFactory : IDesignTimeDbContextFactory<DineOutGQLDbContext>
    {
        public DineOutGQLDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<DineOutGQLDbContext>();
            var connectionString = configuration.GetConnectionString("DineOutGQLDbContextConnection");
            builder.UseSqlServer(connectionString);

            return new DineOutGQLDbContext(builder.Options);
        }
    }
}
