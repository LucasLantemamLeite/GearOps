using GearOps.Domain.ValueObjects.Base;

namespace GearOps.Domain.ValueObjects.CompanyObjects;

public sealed class Status : ValueObject
{
    public bool Value { get; private set; } = true;

    public Status(bool status) => Value = status;

    private Status() { }
}