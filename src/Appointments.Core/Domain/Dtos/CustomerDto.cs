namespace Appointments.Core.Domain.Dtos
{
    public class CustomerDto
    {
        public CustomerDto(string id, string name, string document, DateTime birthDate, bool isActive)
        {
            Id = id;
            Name = name;
            Document = document;
            BirthDate = birthDate;
            IsActive = isActive;
        }

        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Document { get; private set; }
        public DateTime BirthDate { get; private set; }
        public bool IsActive { get; private set; }
    }
}
