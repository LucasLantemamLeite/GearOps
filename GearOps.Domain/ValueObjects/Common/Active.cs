namespace GearOps.Domain.ValueObjects.Common;

public sealed class Active : ValueObject
{
    public bool Value { get; private set; } = true;

    public Active(bool active) => Value = active;

    public Active() { }
}