namespace SunamoEssential.Essential;

public class WebApp
{
    public static LangsShared Lang { get; set; } = LangsShared.en;

    public static ResourcesShared Resources { get; set; } = null!;

    public static string Name { get; set; } = null!;

    public static bool Initialized { get; } = false;

    public static string Namespace { get; set; } = "";

    public static event Action<TypeOfMessageShared, string>? StatusSetted;

    public static void SetStatus(TypeOfMessageShared messageType, string status, params string[] args)
    {
        StatusSetted?.Invoke(messageType, string.Format(status, args));
    }
}
