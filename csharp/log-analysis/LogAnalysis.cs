using System;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string source, string start) => source.Substring(source.IndexOf(start) + start.Length);
    public static string SubstringBetween(this string source, string start, string end) => source.Substring(source.IndexOf(start) + start.Length, source.IndexOf(end) - source.IndexOf(start) - start.Length);

    public static string Message(this string logLine) => logLine.Substring(logLine.IndexOf(':') + 1).Trim();

    public static string LogLevel(this string logLine) => logLine.Substring(1, logLine.IndexOf(':') - 2);
}