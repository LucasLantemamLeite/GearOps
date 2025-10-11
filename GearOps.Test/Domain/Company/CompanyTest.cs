using GearOps.Domain.ValueObjects.Company;

namespace GearOps.Test.Domain.Company;

[Trait("Category", "CompanyTests")]
public sealed class CompanyTests
{
    [Theory]
    [InlineData("05.338.815/0001-07")]
    [InlineData("36.032.270/0001-21")]
    [InlineData("49887200000105")]
    public void CNPJ_WhenValid_ShouldNotThrowDomainException(string cnpj)
    {
        var ex = Record.Exception(() => new CNPJ(cnpj));
        Assert.Null(ex);
    }

    [Theory]
    [InlineData("05 338 815 0001 07")]
    [InlineData("36!032/270.0001*21")]
    [InlineData("49-8872.000001/05")]
    public void CNPJ_WhenHasInvalidFormat_ShouldThrowCNPJException(string cnpj)
    {
        var ex = Assert.Throws<CNPJException>(() => new CNPJ(cnpj));
        Assert.NotNull(ex);
        Assert.Equal("Formato do CNPJ inválido.", ex.Message);
    }

    [Theory]
    [InlineData("05.338.815/0001-17")]
    [InlineData("36.032.270/0001-51")]
    [InlineData("49887200000129")]
    public void CNPJ_WhenHasInvalidCheckDigits_ShouldThrowCNPJException(string cnpj)
    {
        var ex = Assert.Throws<CNPJException>(() => new CNPJ(cnpj));
        Assert.NotNull(ex);
        Assert.Equal("Dígito verificador incorreto.", ex.Message);
    }
}
