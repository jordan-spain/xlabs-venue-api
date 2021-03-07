using Microsoft.Extensions.Options;
using XLabs.Venue.Api.Configuration;

namespace XLabs.Venue.Api.AcceptanceTests.Infrastructure
{
    public class TestDataAccessOptions : IOptions<DataAccessOptions>
    {
        public DataAccessOptions Value => new DataAccessOptions { FilePath = "FixtureData/leedsbeerquest.csv" };
    }
}
