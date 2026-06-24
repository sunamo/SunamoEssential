namespace SunamoEssential.Essential.EventArgsNs;

public class UriEventArgs : EventArgs
{
    public UriEventArgs(Uri uri)
    {
        Uri = uri;
    }

    public Uri Uri { get; }
}
