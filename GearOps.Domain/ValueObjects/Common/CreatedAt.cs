using GearOps.Domain.ValueObjects.Base;

namespace GearOps.Domain.ValueObjects.Common;

public sealed class CreatedAt : ValueObject
{
    public DateTime Value { get; private set; }

    public CreatedAt(DateTime created) => Value = created;

    public CreatedAt() => Value = DateTime.UtcNow;
}