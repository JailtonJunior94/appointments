using Appointments.Core.Domain.Dtos;

namespace Appointments.Core.Domain.Interfaces.Services
{
    public interface ICustomerService
    {
        Task<CustomerDto> CreateCustomerAsync(CreateCustomerDto req);
    }
}
