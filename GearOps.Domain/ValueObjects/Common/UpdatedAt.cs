using GearOps.Domain.ValueObjects.Base;

namespace GearOps.Domain.ValueObjects.Common;

public sealed class UpdatedAt : ValueObject
{
    public DateTime Value { get; private set; }

    public UpdatedAt(DateTime updated) => Value = updated;

    public UpdatedAt() => Value = DateTime.UtcNow;
}