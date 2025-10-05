namespace GearOps.Domain.ValueObjects.UserAccount;

public sealed class Name : ValueObject
{
    public string Value { get; private set; } = null!;

    public Name(string name) => Value = name;

    private Name() { }
}