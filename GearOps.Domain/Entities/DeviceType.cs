using Type = GearOps.Domain.ValueObjects.Common.Type;

namespace GearOps.Domain.Entities;

public sealed class DeviceType : Entity
{
    public Image? Image { get; private set; } = null;
    public Type Type { get; private set; } = null!;
    public CreatedAt CreatedAt { get; private set; } = new();
    public CompanyId CompanyId { get; private set; } = null!;

    public DeviceType(string? imageUrl, string type, Guid companyId)
    {
        Image = new(imageUrl);
        Type = new(type);
        CompanyId = new(companyId);
    }

    public DeviceType(string type, Guid companyId)
    {
        Type = new(type);
        CompanyId = new(companyId);
    }

    public DeviceType(Guid id, string? imageUrl, string type, DateTime created, Guid companyId) : base(id)
    {
        Image = new(imageUrl);
        Type = new(type);
        CreatedAt = new(created);
        CompanyId = new(companyId);
    }

    private DeviceType() { }
}