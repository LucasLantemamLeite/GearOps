namespace GearOps.Domain.ValueObjects.Company;

public sealed class CNPJ : ValueObject
{
    public string Value { get; private set; } = null!;

    public CNPJ(string cnpj)
    {
        CNPJException.ThrowIfInvalid(cnpj, "Formtato do CNPJ inválido.", "Digito verificador incorreto.");
        Value = cnpj;
    }

    private CNPJ() { }
}