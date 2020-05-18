using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DapperCoreTest.Business;
using DapperCoreTest.BusinesStock;
using DapperCoreTest.Repositories;
using DapperCoreTest.Repositories.Interfaces;
using DapperCoreTest.Repositories.Stock;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace DapperCoreTest
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
            services.AddTransient<IOrquestaStock, OrquestaStock>();
            services.AddTransient<IBuscarReglas, BuscarReglas>();
            services.AddTransient<IBuscarOperacionesCliente, BuscarOperacionesCliente>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
