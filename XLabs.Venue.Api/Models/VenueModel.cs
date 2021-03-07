namespace XLabs.Venue.Api.Models
{
    public class VenueModel
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Excerpt { get; set; }

        public string Img { get; set; }

        public string Address { get; set; }

        public double BeerRating { get; set; }

        public double AtmosphereRating { get; set; }

        public double AmenitiesRating { get; set; }

        public double ValueRating { get; set; }

        public string[] Tags { get; set; }
    }
}

