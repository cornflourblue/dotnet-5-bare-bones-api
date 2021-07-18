using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi
{
    public class Startup
    {
        // add services to the DI container
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
        }

        // configure the HTTP request pipeline
        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();
            app.UseEndpoints(x => x.MapControllers());
        }
    }
}