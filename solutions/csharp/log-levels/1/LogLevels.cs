static class LogLine
{
    const char Seperator = ':';
    
    public static string Message(string logLine) => logLine.Substring(logLine.IndexOf(Seperator) + 1).Trim();

    public static string LogLevel(string logLine)
    {
        var level = logLine.Substring(0, logLine.IndexOf(Seperator)).ToLower();
        return level.Substring(1, level.Length - 2);
    }

    public static string Reformat(string logLine) => $"{Message(logLine)} ({LogLevel(logLine)})";
}
