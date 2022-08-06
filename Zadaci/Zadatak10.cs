using System.Text;
using System.Collections.Generic;
using System;
/*
Complete the square sum function so that it squares each 
number passed into it and then sums the results together.

For example, for [1, 2, 2] it should return 9 because 1^2 + 2^2 + 2^2 = 9.
*/


public static class SquareNumber
{
    public static int Get(int[] numbers)
    {
        List<double> arrayOfSquaredNumbers = new List<double>();



        for (int i = 0; i < numbers.Length; i++)
        {
            var sqNumber = Math.Pow(numbers[i], 2);
            arrayOfSquaredNumbers.Add(sqNumber);
            continue;
        }

        var sum = arrayOfSquaredNumbers.Sum();
        return Convert.ToInt32(sum);
    }

}
