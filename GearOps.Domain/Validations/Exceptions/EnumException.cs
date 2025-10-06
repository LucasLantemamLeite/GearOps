namespace GearOps.Domain.Validations.Exceptions;

public sealed class EnumException(string message) : Exception(message)
{
    public static void ThrowIfNotDefined<T>(int value, string message) where T : Enum
    {
        if (!Enum.IsDefined(typeof(T), value))
            throw new EnumException(message);
    }
}