using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using XLabs.Venue.Api.Configuration;

namespace XLabs.Venue.Api.AcceptanceTests.Infrastructure
{
    public class AppFactory : WebApplicationFactory<Startup>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureTestServices(services =>
            {
                var descriptor =
                    new ServiceDescriptor(
                        typeof(IOptions<DataAccessOptions>),
                        typeof(TestDataAccessOptions),
                        ServiceLifetime.Transient);

                services.Replace(descriptor);
            });
        }
    }
}
