namespace GearOps.Domain.ValueObjects.User;

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