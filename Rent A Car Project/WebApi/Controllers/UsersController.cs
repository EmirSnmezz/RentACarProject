using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService; 
        public UsersController(IUserService userService) 
        {
            _userService = userService;
        }

        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            var result = _userService.Add(user);
            if(result.IsSuccess == false)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(User user)
        {
            var result = _userService.Delete(user);
            if(result.IsSuccess == false) 
            {
                return BadRequest(result);
            }
         
            return Ok(result);

        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _userService.GetAll();
            if(result.IsSuccess == false) 
            {
                return BadRequest(result);
            }

            return Ok(result);
        }
    }
}
