using System;
using System.Collections.Generic;
using System.Linq;

public static class ScrabbleScore
{
    private static readonly Dictionary<int, string> compressedScores = new Dictionary<int, string>() {
        {1, "AEIOULNRST"},
        {2, "DG"},
        {3, "BCMP"},
        {4, "FHVWY"},
        {5, "K"},
        {8, "JX"},
        {10, "QZ"}
    };

    private static readonly Dictionary<char, int> Lookup = new Dictionary<char, int>();
    static ScrabbleScore()
    {
        foreach (KeyValuePair<int, string> kvp in compressedScores)
        {
            foreach (char chr in kvp.Value.ToCharArray())
            {
                Lookup.Add(chr, kvp.Key);
            }
        }
    }

    public static int Score(string input) => input.ToUpper().ToCharArray().Sum(chr => Lookup[chr]);
}