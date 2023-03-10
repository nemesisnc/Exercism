using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine.Substring(logLine.IndexOf(':') + 1).Trim();
    }

    public static string LogLevel(string logLine)
    {
        return logLine.Substring(1, logLine.IndexOf(':') - 2).ToLower();
    }

    public static string Reformat(string logLine)
    {
        string message = logLine.Substring(logLine.IndexOf(':') + 1).Trim();
        string level = logLine.Substring(1, logLine.IndexOf(':') - 2).ToLower();

        return $"{message} ({level})";
    }
}
