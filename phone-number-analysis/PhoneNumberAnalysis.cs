using System;
using System.Text.RegularExpressions;

public static class PhoneNumber
{
    private static bool IsNewYorkCode(string dialingCode) => dialingCode == "212";
    private static bool IsFakeNumber(string secondPartOfNumber) => secondPartOfNumber == "555";

    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string[] phoneNumberSplited = phoneNumber.Split("-");

        if (!string.IsNullOrEmpty(phoneNumber) && Regex.Match(phoneNumber, @"^[1-9]\d{2}-[1-9]\d{2}-\d{4}$").Success)
        {
            return (IsNewYorkCode(phoneNumberSplited[0]),IsFakeNumber(phoneNumberSplited[1]), phoneNumberSplited[2]);
        }

        return (false, false, string.Empty);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
