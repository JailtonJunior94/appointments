using Appointments.Core.Domain.Dtos;
using Appointments.Core.Domain.Entities;
using Appointments.Core.Domain.Interfaces.Services;
using Appointments.Core.Domain.Interfaces.Repositories;

namespace Appointments.Core.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<CustomerDto> CreateCustomerAsync(CreateCustomerDto req)
        {
            Customer newCustomer = new(req.Name, req.Document, req.BirthDate);
            Customer customer = await _repository.InsertAsync(newCustomer);

            CustomerDto response = new(customer.Id, customer.Name, customer.Document, customer.BirthDate, customer.IsActive);

            return response;
        }
    }
}
