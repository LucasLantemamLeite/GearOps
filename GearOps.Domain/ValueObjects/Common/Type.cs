namespace GearOps.Domain.ValueObjects.Common;

public sealed class Type : ValueObject
{
    public string Value { get; private set; } = null!;

    public Type(string type) => Value = type;

    private Type() { }
}