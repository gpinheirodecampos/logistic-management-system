namespace Domain.Entities;

public class Driver
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Name { get; set; }
    public string? License { get; set; }
    public bool IsAvailable { get; set; }

    public ICollection<Delivery>? Deliveries { get; set; }
}

