﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;

namespace Bookstore
{
    class Program
    {
        static void Main(string[] args)
        {
            
                CreateHostBuilder(args).Build().Run();
            
        }


        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<startup>();
                });
    }
}
