using GearOps.Domain.ValueObjects.Base;

namespace GearOps.Domain.ValueObjects.CompanyObjects;

public sealed class CNPJ : ValueObject
{
    public string Value { get; private set; } = null!;

    public CNPJ(string cpnj)
    {
        Value = cpnj;
    }

    private CNPJ() { }
}