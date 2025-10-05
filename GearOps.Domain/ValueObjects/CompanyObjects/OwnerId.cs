using GearOps.Domain.ValueObjects.Base;

namespace GearOps.Domain.ValueObjects.CompanyObjects;

public sealed class OwnerId : ValueObject
{
    public Guid Value { get; private set; }

    public OwnerId(Guid id) => Value = id;

    private OwnerId() { }
}