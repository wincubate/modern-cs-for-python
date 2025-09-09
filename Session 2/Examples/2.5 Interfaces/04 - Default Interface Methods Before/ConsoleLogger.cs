namespace ModernCS.Session2;

class ConsoleLogger : ILogger
{
    public void Log(LogLevel level, string message)
    {
        switch (level)
        {
            case LogLevel.Error:
                WriteInColor(ConsoleColor.Yellow, message);
                break;
            case LogLevel.Info:
                WriteInColor(ConsoleColor.Green, message);
                break;
            default:
            case LogLevel.Debug:
                WriteInColor(ConsoleColor.Gray, message);
                break;
        }
    }

    private void WriteInColor(ConsoleColor color, string line)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(line);
        Console.ResetColor();
    }
}
