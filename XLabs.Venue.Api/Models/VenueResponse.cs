using Newtonsoft.Json;
using System;

namespace XLabs.Venue.Api.Models
{
    public class VenueResponse
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("excerpt")]
        public string Excerpt { get; set; }

        [JsonProperty("img")]
        public string Img { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("beerRating")]
        public long BeerRating { get; set; }

        [JsonProperty("atmosphereRating")]
        public double AtmosphereRating { get; set; }

        [JsonProperty("amenitiesRating")]
        public long AmenitiesRating { get; set; }

        [JsonProperty("valueRating")]
        public long ValueRating { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }
}

