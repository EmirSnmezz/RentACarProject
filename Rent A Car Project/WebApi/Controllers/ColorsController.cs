using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Linq.Expressions;
using Color = Entities.Concrete.Color;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ColorsController : Controller
    {
        IColorService _colorService;

        public ColorsController(IColorService colorService)
        {
            _colorService = colorService;
        }
        [HttpGet("add")]
        public IActionResult Add(Color color)
        {
            var result = _colorService.Add(color);

            if(result.IsSuccess == false)
            {
                return BadRequest();
            }
                return Ok(result.Message);
            
        }

        [HttpGet("getall")]
        public IActionResult GetAll(Expression <Func<Color , bool>> filter = null)
        {
            var result = filter == null ? _colorService.GetAll() : _colorService.GetAll(filter);
            
            if(result.IsSuccess == false)
            {
                return BadRequest(result);
            }

            return Ok(result); 
        }

        [HttpPost("delete")]
        public IActionResult Delete(Color color)
        {
            var result = _colorService.Delete(color);

            if(result.IsSuccess == false)
            {
                return BadRequest(result);
            }

            return Ok(result);

        }
    }
}
