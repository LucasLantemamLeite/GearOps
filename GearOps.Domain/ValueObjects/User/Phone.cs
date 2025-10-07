namespace GearOps.Domain.ValueObjects.User;

public sealed class Phone : ValueObject
{
    public string Value { get; private set; } = null!;

    public Phone(string phone)
    {
        PhoneException.ThrowIfNotMatch(phone, "Número de telefone inválido.");
        Value = phone;
    }

    private Phone() { }
}