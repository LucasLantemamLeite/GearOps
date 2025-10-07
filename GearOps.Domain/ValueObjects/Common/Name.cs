namespace GearOps.Domain.ValueObjects.Common;

public sealed class Name : ValueObject
{
    public string Value { get; private set; } = null!;

    public Name(string name, string message)
    {
        DomainException.ThrowIfFalse(!string.IsNullOrWhiteSpace(name), message);
        Value = name;
    }

    private Name() { }
}