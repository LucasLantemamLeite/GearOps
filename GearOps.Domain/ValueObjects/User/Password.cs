namespace GearOps.Domain.ValueObjects.User;

public sealed class Password : ValueObject
{
    public string Value { get; private set; } = null!;

    public Password(string password)
    {
        DomainException.ThrowIfFalse(!string.IsNullOrWhiteSpace(password), "Senha do usuário é obrigatório.");
        Value = password;
    }

    private Password() { }
}