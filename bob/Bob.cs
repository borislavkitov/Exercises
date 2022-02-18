using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        var input = statement.TrimEnd();
        if (input == "") return "Fine. Be that way!";
        var isQuestion = input.EndsWith("?");
        var isYelling = statement.ToUpper() == statement && statement.Any(x => char.IsLetter(x));

         if (isQuestion && isYelling)
        {
            return "Calm down, I know what I'm doing!";
        }
        else if (isQuestion)
        {
            return "Sure.";
        }

        else if (isYelling)
        {
            return "Whoa, chill out!";
        }
        else
        {
            return "Whatever.";
        }
    }
}