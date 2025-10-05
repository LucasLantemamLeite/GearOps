using GearOps.Domain.ValueObjects.Base;

namespace GearOps.Domain.ValueObjects.Common;

public sealed class Image : ValueObject
{
    public string? Value { get; private set; }

    public Image(string? imageUrl) => Value = imageUrl;

    private Image() { }
}