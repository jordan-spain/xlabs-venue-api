using Microsoft.AspNetCore.Mvc;
using System;
using XLabs.Venue.Api.DataAccess.Interfaces;

namespace XLabs.Venue.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VenuesController : ControllerBase
    {
        private readonly IVenueRepository _venueRepository;

        public VenuesController(IVenueRepository venueRepository)
        {
            _venueRepository = venueRepository ?? throw new ArgumentNullException(nameof(venueRepository));
        }

        [HttpGet]
        public IActionResult GetAllVenues()
        {
            var venues = _venueRepository.GetAll();

            return Ok(venues);
        }

        [HttpGet("{id}")]
        public IActionResult GetVenue(int id)
        {
            var venue = _venueRepository.Get(id);

            if (venue == null)
                return NotFound();

            return Ok(venue);
        }
    }
}
