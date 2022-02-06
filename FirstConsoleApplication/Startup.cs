using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace FirstConsoleApplication
{
    public class Startup
    {
        public void ConfigurationServices()
        {
            
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();

            app.UseEndpoints(endpoints =>
           {
               endpoints.MapGet("/", async context =>
               {
                   await context.Response.WriteAsync("Hello from endpoints");
               });

           });
        }
    }
}
