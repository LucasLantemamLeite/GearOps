namespace GearOps.Domain.ValueObjects.Device;

public sealed class Description : ValueObject
{
    public string? Value { get; private set; }

    public Description(string? description)
    {
        Value = description;
    }

    private Description() { }
}