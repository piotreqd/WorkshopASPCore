using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using WorkshopAsp.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using WorkshopAsp.Models.DomainModel;
using WorkshopAsp.Models.DomainModel.Interfaces;
using WorkshopAsp.Models.DomainModel.Repositories;

namespace WorkshopAsp
{
    public class Startup
    {
        public IConfiguration Configuration { get;}
        public Startup(IConfiguration configuration) =>
            Configuration = configuration;
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<WorkshopContext>(options =>
                options.UseSqlServer(
                    Configuration["Data:Workshop:ConnectionString"]));
            services.AddTransient<IOwnerRepository, OwnerRepository>();
            services.AddTransient<ICarRepository, CarRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Owner}/{action=List}/{id?}");
            });
            //Seed.EnsurePopulated(app);
            /*if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });*/
        }
    }
}
