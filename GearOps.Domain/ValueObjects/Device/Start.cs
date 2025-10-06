namespace GearOps.Domain.ValueObjects.Device;

public sealed class Start : ValueObject
{
    public DateTime? Value { get; private set; }

    public Start(DateTime? starDate) => Value = starDate;

    private Start() { }
}