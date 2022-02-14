using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using Appointments.Core.Domain.Entities;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Bson.Serialization.IdGenerators;

namespace Appointments.Core.Infra.Mappings
{
    public class CustomerMap
    {
        public static void Configure()
        {
            BsonClassMap.RegisterClassMap<Customer>(map =>
            {
                map.AutoMap();
                map.SetIgnoreExtraElements(true);
                map.SetIsRootClass(true);

                map.MapCreator(map => new Customer(map.Name, map.Document, map.BirthDate));

                map.MapIdProperty(x => x.Id).SetIdGenerator(StringObjectIdGenerator.Instance);
                map.IdMemberMap.SetSerializer(new StringSerializer().WithRepresentation(BsonType.ObjectId));

                map
                .MapMember(x => x.Document)
                .SetElementName("document")
                .SetOrder(2)
                .SetIgnoreIfNull(true)
                .SetIsRequired(true)
                .SetSerializer(new StringSerializer(BsonType.String));

                map
                .MapMember(x => x.Name)
                .SetElementName("name")
                .SetOrder(3)
                .SetIgnoreIfNull(true)
                .SetIsRequired(true)
                .SetSerializer(new StringSerializer(BsonType.String));

                map
                .MapMember(x => x.BirthDate)
                .SetElementName("birthDate")
                .SetOrder(4)
                .SetIgnoreIfNull(false)
                .SetIsRequired(true)
                .SetSerializer(new DateTimeSerializer(dateOnly: false));

                map
                .MapMember(x => x.CreatedAt)
                .SetElementName("createdAt")
                .SetOrder(5)
                .SetIgnoreIfNull(false)
                .SetIsRequired(true)
                .SetSerializer(new DateTimeSerializer(dateOnly: false));

                map
                .MapMember(x => x.UpdatedAt)
                .SetElementName("updatedAt")
                .SetOrder(6)
                .SetIgnoreIfNull(true)
                .SetIsRequired(true)
                .SetSerializer(new DateTimeSerializer(dateOnly: false));

                map
                .MapMember(x => x.IsActive)
                .SetElementName("isActive")
                .SetIgnoreIfNull(true)
                .SetIsRequired(false)
                .SetSerializer(new BooleanSerializer(BsonType.Boolean));
            });
        }
    }
}
