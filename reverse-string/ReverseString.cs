using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        if (!String.IsNullOrEmpty(input))
        {

            var v = input.ToCharArray();
            char[] inputAsArray = v;

            Array.Reverse(inputAsArray);

            string reverseStr = new string(inputAsArray);

            return reverseStr;
        }
        else
        {
            return "";
        }
    }
}