using CsvHelper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using XLabs.Venue.Api.Configuration;
using XLabs.Venue.Api.DataAccess.Interfaces;
using XLabs.Venue.Api.DataAccess.Models;
using XLabs.Venue.Api.Models;

namespace XLabs.Venue.Api.DataAccess
{
    public class FileBasedVenueRepository : IVenueRepository
    {
        private readonly IEnumerable<VenueModel> _venues;

        public FileBasedVenueRepository(IOptions<DataAccessOptions> dataAccessOptions)
        {
            if (dataAccessOptions is null)
                throw new ArgumentNullException(nameof(dataAccessOptions));

            var mapped = new List<VenueModel>();

            var index = 1;

            using var reader = new StreamReader(dataAccessOptions.Value.FilePath);
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();
                while (csv.Read())
                {
                    var record = csv.GetRecord<VenueCsvModel>();
                    mapped.Add(Map(index, record));
                    index++;
                }
            }

            _venues = mapped;
        }

        public VenueModel Get(int key)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VenueModel> GetAll() => _venues;

        private VenueModel Map(int id, VenueCsvModel csvRecord) => new VenueModel
        {
            Id = id,
            Name = csvRecord.Name,
            Excerpt = csvRecord.Excerpt,
            Img = csvRecord.Thumbnail,
            Address = csvRecord.Address,
            BeerRating = csvRecord.StarsBeer,
            AtmosphereRating = csvRecord.StarsAtmosphere,
            AmenitiesRating = csvRecord.StarsAmenities,
            ValueRating = csvRecord.StarsValue,
            Tags = csvRecord.Tags.Split(",")
        };
    }
}
