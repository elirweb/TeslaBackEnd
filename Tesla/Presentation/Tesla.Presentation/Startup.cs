using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.IO;
using System;
using Tesla.IOC;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;
using Microsoft.EntityFrameworkCore;

namespace Tesla.Presentation
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpClient();
            services.AddDbContext<Util.Connection>(options => options.UseSqlServer(Util.Constant.GetStrinConnection));

            Bootstrap.Register(services);

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                   builder =>
                   {
                       builder.AllowAnyOrigin()
                      .AllowAnyMethod()
                      .AllowAnyHeader()
                      .AllowAnyOrigin();
                   });
            });

            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
                app.UseDeveloperExceptionPage();
            //}

            app.UseHttpsRedirection();

            app.UseExceptionHandler(
                options =>
                {
                    options.Run(
                        async context =>
                        {
                            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                            context.Response.ContentType = "text/html";
                            var exceptionObject = context.Features.Get<IExceptionHandlerFeature>();
                            if (exceptionObject != null)
                            {
                                var errorMessage = $"<b>Error: {exceptionObject.Error.Message}</b> {exceptionObject.Error.StackTrace}";

                                await context.Response.WriteAsync(errorMessage).ConfigureAwait(false);
                            }
                        });
                }
            );

            app.UseSwagger();
            app.UseRouting();
            app.UseSwaggerUI(setup =>
            {
                setup.SwaggerEndpoint("/swagger/v1/swagger.json", "Tesla");
            });

            app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
        }
    }
}
