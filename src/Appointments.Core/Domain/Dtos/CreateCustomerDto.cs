namespace Appointments.Core.Domain.Dtos
{
    public class CreateCustomerDto
    {
        public string Name { get; set; } = string.Empty;
        public string Document { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
    }
}
