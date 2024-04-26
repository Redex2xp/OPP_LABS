using System.Globalization;

namespace laba_1_2;

public class UsaDateTimeFormatter:INowDateTimeFormatter
{
    public string FormataDateTime()
    {
        CultureInfo usa = CultureInfo.CreateSpecificCulture("en-US");
        return DateTime.Now.ToString(usa);
    }
}