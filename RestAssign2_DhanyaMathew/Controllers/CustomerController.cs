using Microsoft.AspNetCore.Mvc;
using RestAssign2_DhanyaMathew.Dtos;
using RestAssign2_DhanyaMathew.Interfaces;

namespace RestAssign2_DhanyaMathew.Controllers
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

        [HttpGet]
        public ActionResult<IEnumerable<CustomerDto>> GetAllCustomers()
        {
            var customers = _customerService.GetAllCustomers();
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public ActionResult<CustomerDto> GetCustomerById(int id)
        {
            var customer = _customerService.GetCustomerById(id);
            if (customer == null)
            {
                return NoContent();
            }
            return Ok(customer);
        }

        [HttpPost]
        public ActionResult AddCustomer(CustomerDto customerDto)
        {
            _customerService.AddCustomer(customerDto);
            return Ok();
        }

        [HttpPut]
        public ActionResult UpdateCustomer(CustomerDto customerDto)
        {
            _customerService.UpdateCustomer(customerDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCustomer(int id)
        {
            _customerService.DeleteCustomer(id);
            return Ok();
        }
    }
}
