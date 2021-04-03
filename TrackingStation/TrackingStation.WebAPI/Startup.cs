using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using TrackingStation.BLL.Declaration;
using TrackingStation.BLL.Implementation;
using TrackingStation.DataAccess.Declaration;
using TrackingStation.DataAccess.Implementation;

namespace TrackingStation.WebAPI
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
            services.AddControllers();
            services.AddAutoMapper(typeof(Startup));

            services.Add(new ServiceDescriptor(typeof(IVesselServant), typeof(VesselServant), ServiceLifetime.Scoped));
            services.Add(new ServiceDescriptor(typeof(IBodyServant), typeof(BodyServant), ServiceLifetime.Scoped));

            services.Add(new ServiceDescriptor(typeof(IVesselDataAccess), typeof(VesselDataAccess), ServiceLifetime.Transient));
            services.Add(new ServiceDescriptor(typeof(IBodyDataAccess), typeof(BodyDataAccess), ServiceLifetime.Transient));

            services.AddDbContext<DataAccess.Context.DataContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
