using System.Globalization;

namespace laba_1_2;

public class EuropeDateTimeFormatter:INowDateTimeFormatter
{
    public string FormataDateTime()
    {
        CultureInfo europe = CultureInfo.CreateSpecificCulture("cs-CZ");
        return DateTime.Now.ToString(europe);
    }
}