using System;

public static class LogAnalysis
{
    private const string MessageDelimiter = ":";
    private const string LogLevelFirstDelimiter = "[";
    private const string LogLevelSecondDelimiter = "]";

    public static string SubstringAfter(this string msg, string delimiter) =>
        msg.Substring(msg.IndexOf(delimiter) + delimiter.Length);

    public static string SubstringBetween(this string msg, string firstDelimiter, string secondDelimiter) =>
        msg.Substring(msg.IndexOf(firstDelimiter) + firstDelimiter.Length, (msg.IndexOf(secondDelimiter) - (msg.IndexOf(firstDelimiter) + firstDelimiter.Length)));

    public static string Message(this string wholeErrorMsg) => wholeErrorMsg.Split(MessageDelimiter)[1].Trim();

    public static string LogLevel(this string wholeErrorMsg) => wholeErrorMsg.SubstringBetween(LogLevelFirstDelimiter, LogLevelSecondDelimiter);
}