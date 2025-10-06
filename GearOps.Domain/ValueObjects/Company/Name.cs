namespace GearOps.Domain.ValueObjects.Company;

public sealed class Name : ValueObject
{
    public string Value { get; private set; } = null!;

    public Name(string name)
    {
        DomainException.ThrowIfFalse(!string.IsNullOrWhiteSpace(name), "Nome da empresa é obrigatório.");
        Value = name;
    }

    private Name() { }
}