using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalService; 
        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpGet("getall")]
        public IActionResult ListOfRentalsInfo()
        {
            var result = _rentalService.GetAll();

            if(result.IsSuccess == false)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }
    }
}
