using Appointments.Core.Domain.Entities;

namespace Appointments.Core.Domain.Interfaces.Repositories
{
    public interface ICustomerRepository
    {
        Task<Customer> InsertAsync(Customer entity);
    }
}
