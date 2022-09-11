using AKD.AKDTrading.Services.Finance.API.DomainModels;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using PUCARS.API.Interfaces;
using PUCARS.API.Services;
using SoapCore;
using SOAPTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;

namespace PUCARS.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));

            services.AddDbContext<ApplicationDbContext>(
            options => options.UseMySql(Configuration.GetConnectionString("SqlConnection"), serverVersion,
                mySqlOptions =>
                {
                    mySqlOptions.EnableRetryOnFailure(
                    maxRetryCount: 5,
                    maxRetryDelay: TimeSpan.FromSeconds(0),
                    errorNumbersToAdd: null);
                }
             ).EnableSensitiveDataLogging()
             .EnableDetailedErrors());
            services.TryAddSingleton<IAccelerationService, AccelerationService>();
            services.AddTransient<IBoardMeetingService, BoardMeetingService>();
            services.AddSoapCore();
            services.AddMvc();
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseRouting();
            app.UseSoapEndpoint<IAccelerationService>("/pucars/wsdl", new SoapEncoderOptions(), SoapSerializer.XmlSerializer, false, null, null);
            app.UseSoapEndpoint<IBoardMeetingService>("/BoardMeetingService.asmx", new SoapEncoderOptions(), SoapSerializer.XmlSerializer, false, null, null);

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //});

        }
    }
}
