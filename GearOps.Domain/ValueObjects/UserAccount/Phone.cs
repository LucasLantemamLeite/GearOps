namespace GearOps.Domain.ValueObjects.UserAccount;

public sealed class Phone : ValueObject
{
    public string Value { get; private set; } = null!;

    public Phone(string phone)
    {
        PhoneException.ThrowIfNotMatch(phone, "Phone inválido.");
        Value = phone;
    }

    private Phone() { }
}