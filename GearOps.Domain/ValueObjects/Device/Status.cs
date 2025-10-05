using GearOps.Domain.Enums.Device;
using GearOps.Domain.ValueObjects.Base;

namespace GearOps.Domain.ValueObjects.Device;

public sealed class Status : ValueObject
{
    public EStatus Value { get; private set; }

    public Status(int status)
    {
        Value = (EStatus)status;
    }

    private Status() { }
}