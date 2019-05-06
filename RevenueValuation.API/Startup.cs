﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RevenueValuation.Data.EF.Repositories;
using RevenueValuation.Data.EF.Repositories.EFImplementation;
using RevenueValuation.Data.Repositories;
using RevenueValuation.Data.Repositories.Interfaces;
using RevenueValuation.Service.Implementation.Employee;
using RevenueValuation.Service.Interfaces.Employee;
using NLog.Extensions.Logging;
using NLog.Web;

namespace RevenueValuation.API
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            env.ConfigureNLog("NLog.config");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            //loggerFactory.AddConsole(Configuration.GetSection("Logging")); //log levels set in your configuration
            //loggerFactory.AddDebug(); //does all log levels
            loggerFactory.AddNLog();
            app.AddNLogWeb();
            //app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
