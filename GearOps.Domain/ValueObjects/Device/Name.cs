namespace GearOps.Domain.ValueObjects.Device;

public sealed class Name : ValueObject
{
    public string Value { get; private set; } = null!;

    public Name(string name)
    {
        DomainException.ThrowIfFalse(!string.IsNullOrWhiteSpace(name), "Nome do dispositivo é obrigatório.");
        Value = name;
    }

    private Name() { }
}