namespace SunamoEssential.Essential;

public class SharedAlgorithms
{
    public static int LastError { get; set; } = -1;

    public static TResult RepeatAfterTimeXTimes<TResult>(int times, int timeoutMs, Func<TResult> operation)
    {
        LastError = -1;
        TResult? result = default;
        bool isSuccessful = false;
        for (int index = 0; index < times; index++)
        {
            try
            {
                result = operation();
                isSuccessful = true;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                if (exception.Message.StartsWith("The remote server returned an error: "))
                {
                    var parts = SHSplit.Split(SHReplace.ReplaceOnce(exception.Message, "The remote server returned an error: ", string.Empty), " ");
                    var errorCode = parts[0].TrimEnd(')').TrimStart('(');
                    LastError = int.Parse(errorCode);
                }
                if (LastError == 404)
                {
                    return result!;
                }
                Thread.Sleep(timeoutMs);
            }
            if (isSuccessful)
            {
                break;
            }
        }
        return result!;
    }
}
