namespace GearOps.Domain.ValueObjects.Device;

public sealed class Return : ValueObject
{
    public DateTime? Value { get; private set; }

    public Return(DateTime? returnDate)
    {
        Value = returnDate;
    }

    private Return() { }
}