/*
When provided with a letter, return its position in the alphabet.

Input :: "a"

Ouput :: "Position of alphabet: 1"


*/
using System.Linq;
using System.Collections.Generic;
using System;

public class PositionAlphabet
{
    private static Dictionary<int,char> alphabetDictionary = new Dictionary<int, char>{
        { 1,'a'},
        {2,'b'},
        {3,'c'},
        {4,'d'},
        {5,'e'},
        {6,'f'},
        {7,'g'},
        {8,'h'},
        {9,'i'},
        {10,'j'},
        {11,'k'},
        {12,'l'},
        {13,'m'},
        {14,'n'},
        {15,'o'},
        {16,'p'},
        {17,'q'},
        {18,'r'},
        {19,'s'},
        {20,'t'},
        {21,'u'},
        {22,'v'},
        {23,'w'},
        {24,'x'},
        {25,'y'},
        {26,'z'}

    };



  public static string Position(char alphabet)
  {
    alphabet = Char.ToLower(alphabet);
    if(alphabetDictionary.ContainsValue(alphabet)){
       var key = alphabetDictionary.FirstOrDefault(x => x.Value == alphabet).Key;
       return $"Position of alphabet: {key}";

    }
    




    return "";
  }
}