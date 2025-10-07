using System.Text.RegularExpressions;

namespace GearOps.Domain.Validations.Exceptions;

public partial class CNPJException(string message) : Exception(message)
{
    [GeneratedRegex(@"^[0-9]{2}(\.)?[0-9]{3}(\.)?[0-9]{3}(\/?)[0-9]{4}(\-)?[0-9]{2}$")]
    private static partial Regex CNPJRegex();

    public static void ThrowIfInvalid(string cnpj, string message, string digitMessage)
    {
        if (!CNPJRegex().IsMatch(cnpj))
            throw new CNPJException(message);

        cnpj = cnpj.Replace(".", "").Replace("/", "").Replace("-", "");

        List<int> cnpjDigits = cnpj[..12].Select(c => c - '0').ToList();

        List<int> weight = [6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2];

        int sum = 0;

        for (int i = 0; i < cnpjDigits.Count; i++)
            sum += cnpjDigits[i] * weight[i + 1];

        if ((sum % 11) < 2)
            cnpjDigits.Add(0);

        else
            cnpjDigits.Add(11 - (sum % 11));

        sum = 0;

        for (int i = 0; i < cnpjDigits.Count; i++)
            sum += cnpjDigits[i] * weight[i];

        if (sum % 11 < 2)
            cnpjDigits.Add(0);

        else
            cnpjDigits.Add(11 - (sum % 11));

        if (!string.Join("", cnpjDigits).Equals(cnpj))
            throw new CNPJException(digitMessage);
    }
}