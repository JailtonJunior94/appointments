using Microsoft.AspNetCore.Mvc;
using Appointments.Core.Domain.Dtos;
using Appointments.Core.Domain.Interfaces.Services;

namespace Appointments.API.Controllers
{
    [Route("v1/customers")]
    public class CustomerController : Controller
    {
        private readonly ICustomerService _service;

        public CustomerController(ICustomerService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomerAsync([FromBody] CreateCustomerDto req)
        {
            CustomerDto customer = await _service.CreateCustomerAsync(req);
            return new ObjectResult(customer) { StatusCode = StatusCodes.Status201Created };
        }
    }
}
