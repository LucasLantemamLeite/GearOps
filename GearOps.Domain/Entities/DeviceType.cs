namespace GearOps.Domain.Entities;

public sealed class DeviceType : Entity
{
    public Name Name { get; private set; } = null!;
    public Image? Image { get; private set; } = null;
    public CreatedAt CreatedAt { get; private set; } = new();
    public Guid CompanyId { get; private set; }

    public DeviceType(string name, Guid company, string? imageUrl = null)
    {
        Image = new(imageUrl);
        Name = new(name, "Nomo do tipo de dispositivo é obrigatório.");
        CompanyId = company;
    }

    public DeviceType(Guid id, string name, DateTime created, Guid company, string? imageUrl = null) : base(id)
    {
        Image = new(imageUrl);
        Name = new(name, "Nomo do tipo de dispositivo é obrigatório.");
        CreatedAt = new(created);
        CompanyId = company;
    }

    private DeviceType() { }
}