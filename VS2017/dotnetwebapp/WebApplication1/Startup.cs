using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace WebApplication1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            // start logger (in command window)
            loggerFactory.AddConsole();

            if (env.IsDevelopment()) // default code added during creation by Visual Studio...
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                // throw a sample exception just to see the app fail:
                throw new Exception("broken...");
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
