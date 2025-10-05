namespace GearOps.Domain.ValueObjects.UserAccount;

public sealed class Password : ValueObject
{
    public string Value { get; private set; } = null!;

    public Password(string password)
    {
        Value = password;
    }

    private Password() { }
}