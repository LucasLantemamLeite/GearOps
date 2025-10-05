using GearOps.Domain.ValueObjects.Base;

namespace GearOps.Domain.ValueObjects.UserAccount;

public sealed class Email : ValueObject
{
    public string Value { get; private set; } = null!;

    public Email(string email)
    {
        Value = email;
    }

    private Email() { }
}