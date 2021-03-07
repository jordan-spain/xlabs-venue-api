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
        public IActionResult Get()
        {
            var venues = _venueRepository.GetAll();

            return Ok(venues);
        }
    }
}
