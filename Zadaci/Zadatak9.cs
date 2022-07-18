using System.Globalization;
using System.Text;
using System;
/*
Trolls are attacking your comment section!

A common way to deal with this situation is to remove all of the vowels from the trolls' comments, neutralizing the threat.

Your task is to write a function that takes a string and return a new string with all vowels removed.

For example, the string "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!".

Note: for this kata y isn't considered a vowel.

*/

public static class DissVowel
{
    public static string Disemvowel(string str)
    {
        StringBuilder j = new StringBuilder();
        for (int i = 0; i < str.Length; i++)
        {
            if (
              String.Equals(str[i].ToString(), "a", StringComparison.OrdinalIgnoreCase) ||
               String.Equals(str[i].ToString(), "e", StringComparison.OrdinalIgnoreCase) ||
                String.Equals(str[i].ToString(), "u", StringComparison.OrdinalIgnoreCase) ||
                 String.Equals(str[i].ToString(), "i", StringComparison.OrdinalIgnoreCase) ||
                  String.Equals(str[i].ToString(), "o", StringComparison.OrdinalIgnoreCase)

            )
            {
                continue;
            }

            j.Append(str[i]);

        }

        return j.ToString();

    }
}