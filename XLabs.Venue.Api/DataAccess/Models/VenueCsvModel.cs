using CsvHelper.Configuration.Attributes;

namespace XLabs.Venue.Api.DataAccess.Models
{
    public class VenueCsvModel
    {
        [Name("name")]
        public string Name { get; set; }
        [Name("category")]
        public string Category { get; set; }
        [Name("url")]
        public string Url { get; set; }
        [Name("date")]
        public string Date { get; set; }
        [Name("excerpt")]
        public string Excerpt { get; set; }
        [Name("thumbnail")]
        public string Thumbnail { get; set; }
        [Name("lat")]
        public double Lat { get; set; }
        [Name("lng")]
        public double Lng { get; set; }
        [Name("address")]
        public string Address { get; set; }
        [Name("phone")]
        public string Phone { get; set; }
        [Name("twitter")]
        public string Twitter { get; set; }
        [Name("stars_beer")]
        public double StarsBeer { get; set; }
        [Name("stars_atmosphere")]
        public double StarsAtmosphere { get; set; }
        [Name("stars_amenities")]
        public double StarsAmenities { get; set; }
        [Name("stars_value")]
        public double StarsValue { get; set; }
        [Name("tags")]
        public string Tags { get; set; }
    }
}
