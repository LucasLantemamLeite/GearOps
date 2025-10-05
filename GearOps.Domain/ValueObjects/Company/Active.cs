using GearOps.Domain.ValueObjects.Base;

namespace GearOps.Domain.ValueObjects.Company;

public sealed class Active : ValueObject
{
    public bool Value { get; private set; } = true;

    public Active(bool status) => Value = status;

    private Active() { }
}