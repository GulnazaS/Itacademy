using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using WebApplication2.Data.Interfaces;
using WebApplication2.Data.mocks;

namespace WebApplication2
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddTransient<IAllCars, MockCars>();
            services.AddTransient<ICarsCategory, MockCategory>();
        }

        private void MockCars()
        {
            throw new NotImplementedException();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseDeveloperExceptionPage();
            app.UseRouting();
            app.UseEndpoints (endpoints =>
            {
                endpoints.MapControllerRoute(name: "default", "{controller=Car}/{action=List}");
            });
        }
    }
}
