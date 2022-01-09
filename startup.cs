using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;

public class startup
{
	


		public void Configurationservices(IServiceCollection service)
		{


		}

		public void configure(IApplicationBuilder app,IWebHostEnvironment env)
		{
			app.UseRouting();
			app.UseEndpoints(endpoints =>
			{



				endpoints.MapGet("/", async context =>
				{

                    await context.Response.WriteAsync("hello bookstore");
				});
			}


			);

		}



		
	}

 

