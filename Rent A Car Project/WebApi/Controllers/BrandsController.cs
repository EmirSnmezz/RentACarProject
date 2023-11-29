using Business.Abstract;
using Data_Access.Abstarct;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        IBrandService _brandService;
        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpPost("add")]
        public IActionResult Add(Brand brand)
        {
            var result = _brandService.Add(brand);

            if(result.IsSuccess == false )
            {
                return BadRequest(result);
            }

            return Ok(result);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(Brand brand) 
        {
            var result = _brandService.Delete(brand);

            if(result.IsSuccess == false)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }

        [HttpPost("Update")]

        public void Update(Brand brand)
        {

        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _brandService.GetAll();   
            if(result.IsSuccess == false)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}
