namespace SunamoEssential.Essential;

public class VpsHelperSunamo
{
    public static bool IsQ
    => Environment.MachineName == "NRJANCIK";

    public const string Ip = "46.36.38.72";

    public const string IpMyPoda = "85.135.38.18";

    public static string LocationOfSqlBackup(string text, string mssqlServerPath)
    {
        var result = mssqlServerPath += @"Backup\" + text + ".bak";
        return result;
    }

    public static string SunamoSln()
    {
        return BasePathsHelperShared.VisualStudioPath + @"sunamo\";
    }

    public static string SunamoCzSln()
    {
        return BasePathsHelperShared.VisualStudioPath + @"sunamo.cz\";
    }

    public static string SunamoProject()
    {
        return Path.Combine(SunamoSln(), "sunamo");
    }
}
