using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebApplication2
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseDeveloperExceptionPage();
        }
    }
}
