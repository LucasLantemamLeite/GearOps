using GearOps.Domain.ValueObjects.Base;

namespace GearOps.Domain.ValueObjects.Device;

public sealed class Return : ValueObject
{
    public DateTime? Value { get; private set; }

}