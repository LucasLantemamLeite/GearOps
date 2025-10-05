using Type = GearOps.Domain.ValueObjects.Common.Type;
using GearOps.Domain.ValueObjects.Device;

namespace GearOps.Domain.Entities;

public sealed class Device : Entity
{
    public Name Name { get; private set; } = null!;
    public Type Type { get; private set; } = null!;
    public Status Status { get; private set; } = null!;
    public Description? Description { get; private set; }
    public Start? Start { get; private set; }
    public Return? Return { get; private set; }
    public CreatedAt CreatedAt { get; private set; } = new();
    public UpdatedAt UpdatedAt { get; private set; } = new();
    public CompanyId CompanyId { get; private set; } = null!;

    public Device(string name, string type, int status, string? description, DateTime? startDate, DateTime? returnDate, Guid company)
    {
        Name = new(name);
        Type = new(type);
        Status = new(status);
        Description = new(description);
        Start = new(startDate);
        Return = new(returnDate);
        CompanyId = new(company);
    }

    public Device(Guid id, string name, string type, int status, string? description, DateTime? startDate, DateTime? returnDate, DateTime created, DateTime updated, Guid company) : base(id)
    {
        Name = new(name);
        Type = new(type);
        Status = new(status);
        Description = new(description);
        Start = new(startDate);
        Return = new(returnDate);
        CreatedAt = new(created);
        UpdatedAt = new(updated);
        CompanyId = new(company);
    }

    private Device() { }
}