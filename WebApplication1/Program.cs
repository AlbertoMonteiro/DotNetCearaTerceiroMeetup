using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using WebApplication1;

Host.CreateDefaultBuilder(args)
    .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>())
    .Build()
    .Run();