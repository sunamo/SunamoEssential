namespace SunamoEssential.Essential;

/// <summary>
/// Represents the clean up type.
/// </summary>
public static class CleanUp
{
    /// <summary>
    /// Streams.
    /// </summary>
    /// <param name="stream">The stream.</param>
    /// <param name="fileStream">The file stream.</param>
    public static void Streams(Stream stream, FileStream fileStream)
    {
        if (stream != null)
        {
            stream.Dispose();
        }
        if (fileStream != null)
        {
            fileStream.Dispose();
        }
    }
}
