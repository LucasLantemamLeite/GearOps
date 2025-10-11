namespace GearOps.Test.Domain.Common;

[Trait("Category", "CommonTests")]
public sealed class CommonTests
{
    [Theory]
    [InlineData("Gabrielle")]
    [InlineData("Diogo")]
    [InlineData("Tomás")]
    public void Name_WhenValidString_ShouldNotThrowDomainException(string name)
    {
        var ex = Record.Exception(() => new Name(name, "Name é obrigatório."));
        Assert.Null(ex);
    }

    [Theory]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData(null)]
    public void Name_WhenEmptyOrNull_ShouldThrowDomainException(string name)
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
    public void Image_WhenValidOrEmptyOrNull_ShouldNotThrowDomainException(string imageUrl)
    {
        var ex = Record.Exception(() => new Image(imageUrl));
        Assert.Null(ex);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void Active_WhenValidBool_ShouldNotThrowDomainException(bool active)
    {
        var ex = Record.Exception(() => new Active(active));
        Assert.Null(ex);
    }

    [Theory]
    [InlineData(2025, 9, 19)]
    [InlineData(2025, 5, 14)]
    public void CreatedAt_WhenValidDate_ShouldNotThrowDomainException(int year, int month, int day)
    {
        var date = new DateTime(year, month, day);
        var ex = Record.Exception(() => new CreatedAt(date));
        Assert.Null(ex);
    }

    [Theory]
    [InlineData(2024, 5, 23)]
    [InlineData(2023, 7, 2)]
    public void UpdatedAt_WhenValidDate_ShouldNotThrowDomainException(int year, int month, int day)
    {
        var date = new DateTime(year, month, day);
        var ex = Record.Exception(() => new UpdatedAt(date));
        Assert.Null(ex);
    }
}
