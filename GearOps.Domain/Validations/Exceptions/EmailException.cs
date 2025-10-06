using System.Text.RegularExpressions;

namespace GearOps.Domain.Validations.Exceptions;

public partial class EmailException(string message) : Exception(message)
{
    [GeneratedRegex(@"^(?=.{1,255}$)(?![.%+_-])(?!.*([.%+_-])\1)[a-zA-Z0-9.%+_-]{1,64}@(([a-zA-Z0-9-]{1,63}\.)*[a-zA-Z0-9-]{1,63}\.[a-zA-Z]{2,63})$")]
    private static partial Regex EmailRegex();

    public static void ThrowIfNotMatch(string email, string message)
    {
        if (!EmailRegex().IsMatch(email))
            throw new EmailException(message);
    }
}