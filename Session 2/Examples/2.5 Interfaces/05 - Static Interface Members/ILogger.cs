namespace ModernCS.Session2;

enum LogLevel
{
    Error,
    Info,
    Debug
}

interface ILogger
{
    static string ProduceExceptionLogString(Exception exception)
    {
        return
            $"Exception occurred: {exception.Message}. " +
            $"Call stack size: {exception.StackTrace?.Length ?? 0}";
    }

    void Log(LogLevel level, string message);
    void Log(Exception exception)
    {
        Log(LogLevel.Error, ProduceExceptionLogString(exception));
    }
}
