using System;
using Microsoft.Extensions.Hosting;
using NET5GenericConsole.App;
using Microsoft.Extensions.DependencyInjection;

namespace NET5GenericConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddSingleton<IAppHost, AppHost>();
                }).Build();

            host.Services.GetService<IAppHost>().Run();
        }
    }
}
