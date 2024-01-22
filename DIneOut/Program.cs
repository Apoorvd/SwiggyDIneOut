
using Dine.DataModel.ContextModel;

namespace DineOut.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var startup = new Startup(builder.Configuration);
            startup.ConfigureServices(builder.Services); // calling ConfigureServices method
            var app = builder.Build();
            startup.Configure(app, builder.Environment);
        }
    }
}
