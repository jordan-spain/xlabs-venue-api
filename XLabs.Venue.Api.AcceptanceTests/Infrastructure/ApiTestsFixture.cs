using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace XLabs.Venue.Api.AcceptanceTests.Infrastructure
{
    public class ApiTestsFixture : IDisposable
    {
        private readonly AppFactory _appFactory;
        private readonly HttpClient _appClient;

        public ApiTestsFixture()
        {
            _appFactory = new AppFactory();
            _appClient = _appFactory.CreateClient();
        }

        public async Task<(HttpStatusCode, TResponse)> HttpGetAsyncWithStatus<TResponse>(string url)
        {
            var response = await _appClient.GetAsync(url);
            var content = await response.Content.ReadAsAsync<TResponse>();
            return (response.StatusCode, content);
        }

        public void Dispose()
        {
            _appFactory.Dispose();
            _appClient.Dispose();
        }
    }
}
