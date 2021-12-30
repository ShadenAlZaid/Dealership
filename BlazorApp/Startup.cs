using Dealership.Data;
using DealershipLibrary;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Linq;

namespace BlazorApp
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
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddDbContext<DbContext>((serviceProvider, dbContextBuilder) =>
            {
                var connectionStringPlaceHolder = Configuration.GetConnectionString("PlaceHolderConnection");
                var httpContextAccessor = serviceProvider.GetRequiredService<IHttpContextAccessor>();
                var dbName = httpContextAccessor.HttpContext.Request.Headers["Id"].First();
                var connectionString = connectionStringPlaceHolder.Replace("{dbName}", dbName);
                dbContextBuilder.UseSqlServer(connectionString);
            });
            services.AddRazorPages();
            services.AddScoped<IVehicleRepository, VehicleRepository>();
            services.AddScoped<ILookupRepository, LookupRepository>();
            services.AddScoped<IVehicleService, VehicleService>();
            services.AddScoped<ILookupService, LookupService>();
            services.AddServerSideBlazor();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
