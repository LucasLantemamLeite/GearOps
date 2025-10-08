namespace GearOps.Domain.ValueObjects.Company;

public sealed class CNPJ : ValueObject
{
    public string Value { get; private set; } = null!;

    public CNPJ(string cnpj)
    {
        CNPJException.ThrowIfInvalid(cnpj, "Formato do CNPJ inválido.", "Dígito verificador incorreto.");
        Value = cnpj;
    }

    private CNPJ() { }
}