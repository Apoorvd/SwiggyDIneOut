using Dine.DataModel.ContextModel;
using Dine.Utilities.SeedDataUtil;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace DineOut.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }   

        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddMvc();

            // Add services to the container.

            // Add DbContext -- all manual steps 
            var builder = new DbContextOptionsBuilder<DineOutGQLDbContext>();
            var connectionString = Configuration.GetConnectionString("DineOutGQLDbContextConnection");
            services.AddDbContext<DineOutGQLDbContext>(option => builder.UseSqlServer(connectionString));


            

            //Add DbContext --- lambda
            //services.AddDbContext<DineOutGQLDbContext>(option => option.UseSqlServer(Configuration.GetConnectionString("DineOutGQLDbContextConnection")));
            services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            //builder.Services.AddSwaggerGen();
            

        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            // Configure the HTTP request pipeline.
            /*if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }*/

            //app.UseGraphiQl();

            //app.UseMvc();

            #region Custom seed data
            var context = app.Services.GetRequiredService<DineOutGQLDbContext>();
            DineOutSeedData.EnsureEnumSeedData(context);
            #endregion
            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
