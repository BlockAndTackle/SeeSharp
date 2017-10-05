using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace MovingToTheWeb
{

	public class Startup // could be called anything
	{
	    public void Configure (IApplicationBuilder app)
        {
            app.Run(context => 
            {
                return context.Response.WriteAsync("Hello Everyosfsdfdsfsdfsdne On the Web!");
            });
        }
	}
}