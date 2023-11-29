using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : Controller
    {
        ICustomerService _customerService;
        public CustomersController(ICustomerService customerService) 
        {
            _customerService = customerService;
        }

      [HttpPost("add")]
      public IActionResult Add(Customer customer)
        {
            var result = _customerService.Add(customer);

            if(result.IsSuccess == false)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Customer customer)
        {
            var result = _customerService.Delete(customer);
            if(result.IsSuccess == false)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            var result = _customerService.GetAll();
            if(result.IsSuccess == false)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }
    }
}
