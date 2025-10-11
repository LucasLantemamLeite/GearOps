using GearOps.Domain.ValueObjects.Device;

namespace GearOps.Domain.Entities;

public sealed class Device : Entity
{
    public Name Name { get; private set; } = null!;
    public Status Status { get; private set; } = null!;
    public DeviceType DeviceType { get; private set; } = new();
    public Description? Description { get; private set; }
    public Start? Start { get; private set; }
    public Return? Return { get; private set; }
    public CreatedAt CreatedAt { get; private set; } = new();
    public UpdatedAt UpdatedAt { get; private set; } = new();
    public Guid DeviceTypeId { get; private set; }
    public Guid CompanyId { get; private set; }

    public Device(string name, int status, DeviceType deviceType, string? description, DateTime? startDate, DateTime? returnDate, Guid device, Guid company)
    {
        Name = new(name, "Nome do dispositivo é obrigatório.");
        DeviceType = deviceType;
        Status = new(status);
        Description = new(description);
        Start = new(startDate);
        Return = new(returnDate);
        DeviceTypeId = device;
        CompanyId = company;
    }

    public Device(Guid id, string name, int status, DeviceType deviceType, string? description, DateTime? startDate, DateTime? returnDate, DateTime created, DateTime updated, Guid device, Guid company) : base(id)
    {
        Name = new(name, "Nome do dispositivo é obrigatório.");
        DeviceType = deviceType;
        Status = new(status);
        Description = new(description);
        Start = new(startDate);
        Return = new(returnDate);
        CreatedAt = new(created);
        UpdatedAt = new(updated);
        DeviceTypeId = device;
        CompanyId = company;
    }

    private Device() { }
}