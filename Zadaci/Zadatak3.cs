using System;
/*
Implement a function which convert the given boolean value into its string representation.

Note: Only valid inputs will be given.
*/

public class BoolToString
{
  public static string boolean_to_string(bool b)
  {
     if(b.GetType() == typeof(bool)){
        return b.ToString();

     }
     

      return "";
  }
}