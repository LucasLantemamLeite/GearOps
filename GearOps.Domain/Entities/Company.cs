using GearOps.Domain.ValueObjects.Company;

namespace GearOps.Domain.Entities;

public sealed class Company : Entity
{
    public Name Name { get; private set; } = null!;
    public Image? Image { get; private set; }
    public CNPJ CNPJ { get; private set; } = null!;
    public Guid OwnerId { get; private set; }
    public CreatedAt CreatedAt { get; private set; } = new();
    public Active Active { get; private set; } = new();

    public Company(string name, string? imageUrl, string cnpj, Guid owner)
    {
        Name = new(name, "Nome da empresa é obrigatório.");
        Image = new(imageUrl);
        CNPJ = new(cnpj);
        OwnerId = owner;
    }

    public Company(Guid id, string name, string? imageUrl, string cnpj, Guid owner, DateTime created, bool active) : base(id)
    {
        Name = new(name, "Nome da empresa é obrigatório.");
        Image = new(imageUrl);
        CNPJ = new(cnpj);
        OwnerId = owner;
        CreatedAt = new(created);
        Active = new(active);
    }

    public Company() { }
}