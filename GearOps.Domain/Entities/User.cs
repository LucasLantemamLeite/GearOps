using GearOps.Domain.ValueObjects.User;

namespace GearOps.Domain.Entities;

public sealed class User : Entity
{
    public Name Name { get; private set; } = null!;
    public Email Email { get; private set; } = null!;
    public Password Password { get; private set; } = null!;
    public Phone Phone { get; private set; } = null!;
    public Role Role { get; private set; } = null!;
    public CreatedAt CreatedAt { get; private set; } = new();
    public UpdatedAt UpdatedAt { get; private set; } = new();
    public Active Active { get; private set; } = new();
    public Guid CompanyId { get; private set; }

    public User(string name, string email, string password, string phone, int role, Guid company)
    {
        Name = new(name, "Nome do usuário é obrigatório.");
        Email = new(email);
        Password = new(password);
        Phone = new(phone);
        Role = new(role);
        CompanyId = company;
    }

    public User(Guid id, string name, string email, string password, string phone, int role, DateTime created, DateTime Updated, bool active, Guid company) : base(id)
    {
        Name = new(name, "Nome do usuário é obrigatório.");
        Email = new(email);
        Password = new(password);
        Phone = new(phone);
        CreatedAt = new(created);
        UpdatedAt = new(Updated);
        Role = new(role);
        Active = new(active);
        CompanyId = company;
    }

    private User() { }
}