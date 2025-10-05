using GearOps.Domain.ValueObjects.Base;

namespace GearOps.Domain.ValueObjects.UserAccount;

public sealed class Phone : ValueObject
{
    public string Value { get; private set; } = null!;

    public Phone(string phone)
    {
        Value = phone;
    }

    private Phone() { }
}