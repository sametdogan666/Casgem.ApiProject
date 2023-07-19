using Casgem.Business.Abstract;
using Casgem.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Casgem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("getlistcustomer")]
        public IActionResult GetListCustomer()
        {
            var results = _customerService.GetList();

            return Ok(results);
        }

        [HttpPost("addcustomer")]
        public IActionResult AddCustomer(Customer customer)
        {
            _customerService.Insert(customer);

            return StatusCode(201, customer);
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteCustomer(int id)
        {
            var result = _customerService.GetById(id);
            _customerService.Delete(result);

            return NoContent();
        }

        [HttpGet("getcustomerbyid/{id:int}")]
        public IActionResult GetCustomerById(int id)
        {
            var result = _customerService.GetById(id);

            return Ok(result);
        }

        [HttpPut]
        public IActionResult UpdateCustomer(Customer customer)
        {
            _customerService.Update(customer);

            return NoContent();
        }
    }
}
