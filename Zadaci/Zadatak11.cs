using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
Write a function that can return the smallest value of an array
 or the index of that value. The function's 2nd parameter will 
 tell whether it should return the value or the index.

Assume the first parameter will always be an array filled with
 at least 1 number and no duplicates. Assume the second parameter 
 will be a string holding one of two values: 'value' and 'index'.

min([1,2,3,4,5], 'value') // => 1
min([1,2,3,4,5], 'index') // => 0
*/


public class FindSmallest
{
    public static int Get(int[] numbers, string toReturn)
    {
        toReturn.ToLower();
        List<int> arr = new List<int>(numbers);
        arr.Distinct();


        if (toReturn == "index")
        {
            var min = arr.Min();
            var indexToReturn = arr.IndexOf(min);
            return indexToReturn;

        }

        if (toReturn == "value")
        {
            var min = arr.Min();
            return min;

        }


        return 0;

    }

}
