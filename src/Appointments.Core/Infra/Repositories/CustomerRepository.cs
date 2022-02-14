using MongoDB.Driver;
using Appointments.Core.Domain.Entities;
using Appointments.Core.Domain.Interfaces.Contexts;
using Appointments.Core.Domain.Interfaces.Repositories;

namespace Appointments.Core.Infra.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IMongoCollection<Customer> _collection;

        public CustomerRepository(IMongoDbContext context)
        {
            _collection = context.GetCollection<Customer>("customer");
        }

        public async Task<Customer> InsertAsync(Customer entity)
        {
            await _collection.InsertOneAsync(entity);
            return entity;
        }
    }
}
