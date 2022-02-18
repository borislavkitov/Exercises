using System;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        if (!string.IsNullOrEmpty(nucleotide))
        {
            

            char[] nucleotideArray = nucleotide.ToUpper().ToCharArray();

            for (int i = 0; i < nucleotideArray.Length; i++)
            {
                if (nucleotideArray[i] == (char)71)
                {
                    nucleotideArray[i] = (char)67;
                }
                else if (nucleotideArray[i] == (char)67)
                {
                    nucleotideArray[i] = (char)71;
                }
                else if (nucleotideArray[i] == (char)84)
                {
                    nucleotideArray[i] = (char)65;
                }
                else 
                {
                    nucleotideArray[i] = (char)85;
                }
            }

            string outputRna = new string(nucleotideArray);


            return outputRna;
        }
        else
        {
            return "";
        }
    }
}