namespace SunamoEssential.Essential;

/// <summary>
/// Represents the web app type.
/// </summary>
public class WebApp
{
    /// <summary>
    /// Gets or sets the lang.
    /// </summary>
    public static LangsShared Lang { get; set; } = LangsShared.en;

    /// <summary>
    /// Gets or sets the resources.
    /// </summary>
    public static ResourcesShared Resources { get; set; } = null!;

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    public static string Name { get; set; } = null!;

    /// <summary>
    /// Gets the initialized.
    /// </summary>
    public static bool Initialized { get; } = false;

    /// <summary>
    /// Gets or sets the namespace.
    /// </summary>
    public static string Namespace { get; set; } = "";

    /// <summary>
    /// The status setted.
    /// </summary>
    public static event Action<TypeOfMessageShared, string>? StatusSetted;

    /// <summary>
    /// Set status.
    /// </summary>
    /// <param name="messageType">The message type.</param>
    /// <param name="status">The status.</param>
    /// <param name="args">The args.</param>
    public static void SetStatus(TypeOfMessageShared messageType, string status, params string[] args)
    {
        StatusSetted?.Invoke(messageType, string.Format(status, args));
    }
}
