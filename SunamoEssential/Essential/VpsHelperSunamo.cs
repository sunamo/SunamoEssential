namespace SunamoEssential.Essential;

/// <summary>
/// Represents the vps helper sunamo type.
/// </summary>
public class VpsHelperSunamo
{
    /// <summary>
    /// The is q.
    /// </summary>
    public static bool IsQ
    => Environment.MachineName == "NRJANCIK";

    /// <summary>
    /// The ip constant.
    /// </summary>
    public const string Ip = "46.36.38.72";

    /// <summary>
    /// The ip my poda constant.
    /// </summary>
    public const string IpMyPoda = "85.135.38.18";

    /// <summary>
    /// Location of sql backup.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <param name="mssqlServerPath">The mssql server path.</param>
    /// <returns>The location of sql backup result.</returns>
    public static string LocationOfSqlBackup(string text, string mssqlServerPath)
    {
        var result = mssqlServerPath += @"Backup\" + text + ".bak";
        return result;
    }

    /// <summary>
    /// Sunamo sln.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <param name="mssqlServerPath">The mssql server path.</param>
    /// <returns>The sunamo sln result.</returns>
    public static string SunamoSln()
    {
        return BasePathsHelperShared.VisualStudioPath + @"sunamo\";
    }

    /// <summary>
    /// Sunamo cz sln.
    /// </summary>
    /// <returns>The sunamo cz sln result.</returns>
    public static string SunamoCzSln()
    {
        return BasePathsHelperShared.VisualStudioPath + @"sunamo.cz\";
    }

    /// <summary>
    /// Sunamo project.
    /// </summary>
    /// <returns>The sunamo project result.</returns>
    public static string SunamoProject()
    {
        return Path.Combine(SunamoSln(), "sunamo");
    }
}
