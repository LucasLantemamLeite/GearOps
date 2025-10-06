using System.Text.RegularExpressions;

namespace GearOps.Domain.Validations.Exceptions;

public partial class PhoneException(string message) : Exception(message)
{
    [GeneratedRegex(@"^\+?[0-9]{1,3}? ?\(?[0-9]{1,4}\)? ?[0-9]{4,10}(-?[0-9]{4,10})?$")]
    private static partial Regex PhoneRegex();

    public static void ThrowIfNotMatch(string phone, string message)
    {
        if (!PhoneRegex().IsMatch(phone))
            throw new PhoneException(message);
    }
}