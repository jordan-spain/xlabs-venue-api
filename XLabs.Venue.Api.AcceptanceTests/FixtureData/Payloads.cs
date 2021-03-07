using System.IO;

namespace XLabs.Venue.Api.AcceptanceTests.FixtureData
{
    public static class Payloads
    {
        public static string GetVenuesResponse() => File.ReadAllText("FixtureData/GetVenuesResponse.json");

        public static string GetVenueResponse() => File.ReadAllText("FixtureData/GetVenueResponse.json");
    }
}
