using System;
using System.Linq;

/*
 Return the number (count) of vowels in the given string.

We will consider a, e, i, o, u as vowels for this Kata (but not y).

The input string will only consist of lower case letters and/or spaces.
*/

public static class Vowel
{
    public static int GetVowelCount(string str)
    {
        str = str.ToLower();
        int vowelCount = 0;
        for(int i = 0; i < str.Length; i++){
            if(str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u'){
                vowelCount += 1;
            }
        }
         

       

        return vowelCount;
    }
}
