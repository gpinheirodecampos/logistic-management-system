using Domain.Enum;

namespace Domain.Entities;

public class Delivery
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid CustomerId { get; set; }
    public Customer? Customer { get; set; }

    public Guid DriverId { get; set; }
    public Driver? Driver { get; set; }

    public DateTime DeliveryDate { get; set; }
    public DeliveryStatus Status { get; set; }
}

