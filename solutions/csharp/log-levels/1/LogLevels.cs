static class LogLine
{
    public static string Message(string logLine)
    {
        string[] splits = new string[2];
        splits = logLine.Split(':');
        return splits[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
        logLine = logLine.TrimStart('[');
        logLine = logLine.Remove(logLine.IndexOf("]"), logLine.Length - logLine.IndexOf("]"));
        logLine = logLine.ToLower();
        return logLine;
    }

    public static string Reformat(string logLine)
    {
        string logLevel = LogLevel(logLine);
        return $"{Message(logLine)} ({logLevel})";
    }
}
