using GearOps.Domain.ValueObjects.Base;

namespace GearOps.Domain.ValueObjects.Company;

public sealed class Logo : ValueObject
{
    public string? Value { get; private set; }

    public Logo(string? logoUrl) => Value = logoUrl;

    private Logo() { }
}