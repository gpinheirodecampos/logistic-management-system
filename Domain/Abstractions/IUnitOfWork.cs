namespace Domain.Abstractions;

public interface IUnitOfWork
{
    ICustomerRepository CustomerRepository { get; }
    IDeliveryRepository DeliveryRepository { get; }
    IDriverRepository DriverRepository { get; }
    IVehicleRepository VehicleRepository { get; }

    Task CommitAsync();
}
