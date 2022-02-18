using System;
using System.Collections.Generic;

public static class ResistorColorTrio
{
    public static string Label(string[] colors)
    {

        Dictionary<string, int> keyPairs = new Dictionary<string, int>()
        {
          {"black", 0},
          {"brown", 1},
          {"red", 2},
          {"orange", 3},
          {"yellow", 4},
          {"green", 5},
          {"blue", 6},
          {"violet", 7},
          {"grey", 8},
          {"white", 9},
        };

        string valueAsString = "";

        for (int i = 0; i < 2; i++)
        {
            valueAsString = valueAsString +  keyPairs[colors[i].ToLower()].ToString();
        }

        for (int i = 0; i < keyPairs[colors[2].ToLower()]; i++)
        {
            valueAsString = (Convert.ToInt32(valueAsString) * 10).ToString();
        }


        if (Convert.ToInt32(valueAsString) % 1000 != 0)
        {
            return (valueAsString + " ohms");
        }
        else
        {
            return ((Convert.ToInt32(valueAsString) / 1000).ToString() + " kiloohms");
        }


    }
}
