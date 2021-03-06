﻿using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;

namespace ConsoleApplication
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();

            app.UseMvc();

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Pre Processing");

            //    await next();

            //    await context.Response.WriteAsync("Post Processing");
            //});

            // Handler of last Resort
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync(
                    "Hello World of the last resort. The Time is: " +
                    DateTime.Now.ToString("hh:mm:ss tt"));

            });
        }
    }
}