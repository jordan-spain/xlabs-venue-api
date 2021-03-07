using Microsoft.AspNetCore.Mvc;
using XLabs.Venue.Api.Models;

namespace XLabs.Venue.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VenuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new[] { new VenueResponse
            {
                Id = 1,
                Name = "Almost Famous",
                Excerpt = "Here's something new to Leeds: an ultra-cool burger bar.",
                Img = "http://leedsbeer.info/wp-content/uploads/2014/08/IMG_20140826_174337.jpg",
                Address = "23-25 Great George St, Leeds LS1 3AL",
                BeerRating = 3,
                AtmosphereRating = 4.5,
                AmenitiesRating = 3,
                ValueRating = 3,
                Tags = new [] { "food" }
            }});
        }
    }
}
