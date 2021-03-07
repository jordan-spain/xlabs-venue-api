using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using XLabs.Venue.Api.Configuration;
using XLabs.Venue.Api.DataAccess;
using XLabs.Venue.Api.DataAccess.Interfaces;

namespace XLabs.Venue.Api
{
    public class Startup
    {
        private const string CorsPolicyName = "CorsPolicy";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options => options.AddPolicy(CorsPolicyName,
                builder => builder.AllowAnyMethod().AllowAnyHeader().WithOrigins("http://localhost:3000")));

            services.AddControllers().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
                JsonConvert.DefaultSettings = () => new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                };
            });

            services.Configure<DataAccessOptions>(Configuration.GetSection("DataAccess"));

            services.AddSingleton<IVenueRepository, FileBasedVenueRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors(CorsPolicyName);

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
