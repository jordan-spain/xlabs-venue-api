using Newtonsoft.Json.Linq;
using System.Net;
using System.Threading.Tasks;
using XLabs.Venue.Api.AcceptanceTests.Infrastructure;
using XLabs.Venue.Api.AcceptanceTests.FixtureData;
using Xunit;
using JsonDiffPatchDotNet;

namespace XLabs.Venue.Api.AcceptanceTests
{
    public class VenuesTests : IClassFixture<ApiTestsFixture>
    {
        private readonly ApiTestsFixture _fixture;

        public VenuesTests(ApiTestsFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public async Task Get_returns_200_with_expected_content()
        {
            var (statusCode, response) = await _fixture.HttpGetAsyncWithStatus<JToken>("/venues");

            Assert.Equal(HttpStatusCode.OK, statusCode);
            Assert.True(MatchesExpectedResponse(response, Payloads.GetVenuesResponse()));
        }

        private bool MatchesExpectedResponse(JToken response, string expected)
        {
            var expectedJson = JToken.Parse(expected);
            var diff = new JsonDiffPatch().Diff(response, expectedJson);
            return diff == null;
        }
    }
}
