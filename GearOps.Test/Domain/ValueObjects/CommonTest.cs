namespace GearOps.Test.Domain.ValueObjects;

[Trait("Category", "CommonTest")]
public sealed class CommonTest
{
    [Theory]
    [InlineData("Teste de Nome")]
    [InlineData("Testando Nome")]
    [InlineData("Já testei o Nome")]
    public void Name_ValidString_ShouldNotThrowDomainException(string name)
    {
        var ex = Record.Exception(() => new Name(name, "Name é obrigatório."));
        Assert.Null(ex);
    }

    [Theory]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData(null)]
    public void Name_EmptyOrNull_ShouldThrowDomainException(string name)
    {
        var ex = Assert.Throws<DomainException>(() => new Name(name, "Name é obrigatório."));
        Assert.NotNull(ex);
        Assert.Equal("Name é obrigatório.", ex.Message);
    }

    [Theory]
    [InlineData("https://via.placeholder.com/150")]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData(null)]
    public void Image_ValidOrEmptyOrNull_ShouldNotThrowDomainException(string imageUrl)
    {
        var ex = Record.Exception(() => new Image(imageUrl));
        Assert.Null(ex);
    }

    [Theory]
    [InlineData("a3f5e2d1-9b8c-4f7d-91a2-6c3e4b5f8d9a")]
    [InlineData("d7c2b1a4-5e6f-4d8a-9b3c-1f2e3d4a5b6c")]
    public void CompanyId_ValidGuidId_ShouldNotThrowDomainException(Guid id)
    {
        var ex = Record.Exception(() => new CompanyId(id));
        Assert.Null(ex);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void Active_ValidBool_ShouldNotThrowDomainException(bool active)
    {
        var ex = Record.Exception(() => new Active(active));
        Assert.Null(ex);
    }

    [Theory]
    [InlineData(2025, 9, 19)]
    [InlineData(2025, 5, 14)]
    public void CreatedAt_ValidDate_ShouldNotThrowDomainException(int year, int month, int day)
    {
        var date = new DateTime(year, month, day);

        var ex = Record.Exception(() => new CreatedAt(date));
        Assert.Null(ex);
    }

    [Theory]
    [InlineData(2024, 5, 23)]
    [InlineData(2023, 7, 2)]
    public void UpdatedAt_ValidDate_ShouldNotThrowDomainException(int year, int month, int day)
    {
        var date = new DateTime(year, month, day);

        var ex = Record.Exception(() => new UpdatedAt(date));
        Assert.Null(ex);
    }
}