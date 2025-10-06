namespace GearOps.Domain.Validations.Exceptions;

public sealed class EnumFlagException(string message) : Exception(message)
{
    public static void ThrowIfFlagNotDefined<T>(int value, string message) where T : struct, Enum
    {
        var allEnumValues = Enum.GetValues<T>().Select(e => Convert.ToInt32(e)).Aggregate((a, b) => a | b);

        if ((value & ~allEnumValues) != 0)
            throw new EnumFlagException(message);
    }
}