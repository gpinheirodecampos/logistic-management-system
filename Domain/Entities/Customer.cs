namespace Domain.Entities;

public class Customer
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Name { get; set; }
    public string? Address { get; set; }
    public string? PhoneNumber { get; set; }

    public ICollection<Delivery>? Deliveries { get; set; }
}
