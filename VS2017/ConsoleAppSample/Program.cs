using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using MovingToTheWeb;

namespace ConsoleAppSample
{
    class Program
    {
        static void Main(string[] args)

            // this was a basic Hello World console app, but then was converted into a web app by adding a REF to (through Nuget) to ASPNetCore
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
