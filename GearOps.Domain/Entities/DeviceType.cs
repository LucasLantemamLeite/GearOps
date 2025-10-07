namespace GearOps.Domain.Entities;

public sealed class DeviceType : Entity
{
    public Image? Image { get; private set; } = null;
    public Name Name { get; private set; } = null!;
    public CreatedAt CreatedAt { get; private set; } = new();
    public CompanyId CompanyId { get; private set; } = null!;

    public DeviceType(string name, Guid companyId, string? imageUrl = null)
    {
        Image = new(imageUrl);
        Name = new(name, "Nomo do tipo de dispositivo é obrigatório.");
        CompanyId = new(companyId);
    }

    public DeviceType(Guid id, string name, DateTime created, Guid companyId, string? imageUrl = null) : base(id)
    {
        Image = new(imageUrl);
        Name = new(name, "Nomo do tipo de dispositivo é obrigatório.");
        CreatedAt = new(created);
        CompanyId = new(companyId);
    }

    private DeviceType() { }
}