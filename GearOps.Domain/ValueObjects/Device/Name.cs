using GearOps.Domain.ValueObjects.Base;

namespace GearOps.Domain.ValueObjects.Device;

public sealed class Name : ValueObject
{
    public string Value { get; private set; } = null!;

    public Name(string name)
    {
        Value = name;
    }

    private Name() { }
}