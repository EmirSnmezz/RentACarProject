using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : Controller
    {

        ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
        }


        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
           var result = _carService.Add(car);
            if(result.IsSuccess == false)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }


        [HttpPost("delete")]

        public IActionResult Delete(Car car) 
        {
            var result = _carService.Delete(car);

            if(result.IsSuccess == false)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }


        [HttpGet("getall")]

        public IActionResult GetAll() 
        {
            var result = _carService.GetAll();

            if(result.IsSuccess == false) 
            {
                return BadRequest();
            }
            return Ok(result);
        }


        [HttpGet("getbycolorid")]
        public IActionResult GetByColorId(int colorId)
        {
           var result = _carService.GetByColorId(colorId);

            if(result.IsSuccess == false)
            {
                return BadRequest();
            }
            
            return Ok(result);
        }


        [HttpGet("getbybrandid")]
        public IActionResult GetByBrandId(int brandId)
        {
            var result = _carService.GetByBrandId(brandId);

            if(result.IsSuccess == false)
            {
                return BadRequest();
            }

            return Ok(result);
        }


        [HttpGet("cardetail")]
        public IActionResult GetCarDetail()
        {
            var result = _carService.CarDetail();
            if(result.IsSuccess == false)
            {
                return BadRequest();
            }

            return Ok(result);
        }
    }
}
