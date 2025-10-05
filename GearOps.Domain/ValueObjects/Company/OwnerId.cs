namespace GearOps.Domain.ValueObjects.Company;

public sealed class OwnerId : ValueObject
{
    public Guid Value { get; private set; }

    public OwnerId(Guid id) => Value = id;

    private OwnerId() { }
}