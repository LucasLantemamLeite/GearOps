using GearOps.Domain.ValueObjects.Base;

namespace GearOps.Domain.ValueObjects.UserAccount;

public sealed class CompanyId : ValueObject
{
    public Guid Value { get; private set; }

    public CompanyId(Guid id) => Value = id;

    private CompanyId() { }
}