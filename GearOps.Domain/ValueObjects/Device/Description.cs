namespace GearOps.Domain.ValueObjects.Device;

public sealed class Description : ValueObject
{
    public string? Value { get; private set; }

    public Description(string? description)
    {
        DomainException.ThrowIfFalse(description == null || description.Length <= 70, "Descrição do dispositivo deve ter menos de 70 caracteres.");
        Value = description;
    }

    private Description() { }
}