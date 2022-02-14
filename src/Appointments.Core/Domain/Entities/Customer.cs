using Appointments.Core.Shared.Extensions;

namespace Appointments.Core.Domain.Entities
{
    public class Customer
    {
        public Customer(string name, string document, DateTime birthDate)
        {
            Id = string.Empty;
            Name = name;
            Document = document;
            BirthDate = birthDate;
            CreatedAt = DateTime.Now.GetBrazilianTime();
            UpdatedAt = DateTime.Now.GetBrazilianTime();
            IsActive = true;
        }

        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Document { get; private set; }
        public DateTime BirthDate { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public bool IsActive { get; private set; }

        public Customer Update(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
            UpdatedAt = DateTime.Now.GetBrazilianTime();

            return this;
        }
    }
}
