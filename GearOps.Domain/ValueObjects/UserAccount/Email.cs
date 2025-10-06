namespace GearOps.Domain.ValueObjects.UserAccount;

public sealed class Email : ValueObject
{
    public string Value { get; private set; } = null!;

    public Email(string email)
    {
        EmailException.ThrowIfNotMatch(email, "Email inválido.");
        Value = email.ToLower();
    }

    private Email() { }
}