using MongoDB.Driver;

namespace Appointments.Core.Domain.Interfaces.Contexts
{
    public interface IMongoDbContext
    {
        IMongoCollection<TEntity> GetCollection<TEntity>(string collectionName);
    }
}
