namespace Domain.Entities;

public class Vehicle
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? LicensePlate { get; set; }
    public string? Model { get; set; }
    public int Year { get; set; }

    public Guid DriverId { get; set; }
    public Driver? Driver { get; set; }
}

