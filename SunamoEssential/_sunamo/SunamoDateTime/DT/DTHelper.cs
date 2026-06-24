namespace SunamoEssential._sunamo.SunamoDateTime.DT;

internal class DTHelper
{
    internal static string DateTimeToFileName(DateTime dateTime, bool isIncludingTime)
    {
        string dateDelimiter = "_";
        string spaceDelimiter = "_";
        string timeDelimiter = "_";
        string result = $"{dateTime.Year}{dateDelimiter}{dateTime.Month:D2}{dateDelimiter}{dateTime.Day:D2}";
        if (isIncludingTime)
        {
            result += $"{spaceDelimiter}{dateTime.Hour:D2}{timeDelimiter}{dateTime.Minute:D2}";
        }
        return result;
    }

    internal static string DateToString(DateTime dateTime, LangsShared lang) => DTHelperMulti.DateToString(dateTime, lang);

    internal static string DateTimeToString(DateTime dateTime, LangsShared lang, DateTime minDateTime)
    {
        if (dateTime == minDateTime)
        {
            return lang == LangsShared.cs ? "ItWasNotMentioned" : "NotIndicated";
        }

        if (lang == LangsShared.cs)
        {
            return $"{dateTime.Day}.{dateTime.Month}.{dateTime.Year} {dateTime.Hour:D2}:{dateTime.Minute:D2}";
        }
        else
        {
            return $"{dateTime.Month}/{dateTime.Day}/{dateTime.Year} {dateTime.Hour:D2}:{dateTime.Minute:D2}";
        }
    }
}
