namespace SunamoEssential.Essential.EventArgsNs;

/// <summary>
/// Represents the uri event args type.
/// </summary>
public class UriEventArgs : EventArgs
{
    /// <summary>
    /// Initializes a new instance of the uri event args class.
    /// </summary>
    /// <param name="uri">The uri.</param>
    public UriEventArgs(Uri uri)
    {
        Uri = uri;
    }

    /// <summary>
    /// Gets the uri.
    /// </summary>
    public Uri Uri { get; }
}
