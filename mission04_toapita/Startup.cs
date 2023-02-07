using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission04_toapita
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsEnvironment("Development"))
            {
                app.UseDeveloperExceptionPage();
            }
            //Adding boiler plate code neccesary to create a web app with the default route and access to static files
            app.UseStaticFiles();

            //Use My Routing
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                //Create an endpoint
                endpoints.MapControllerRoute(
                    name: "default",
                    //Use the controller called Home and call the method called index. Id is optional
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                    );
            });

        }
    }
}
