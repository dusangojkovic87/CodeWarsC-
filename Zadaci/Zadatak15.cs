using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codewars.Zadaci
{

    /*Write a function that accepts an array of 10 integers (between 0 and 9), 
    that returns a string of those numbers in the form of a phone number.
    Example:
    Kata.CreatePhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}) // => returns "(123) 456-7890"

    
    */

    public static class Zadatak15
    {
        public static string CreatePhoneNumber(int[] numbers)
        {

            var firstThreeDigits = string.Join("", numbers.Take(3));
            var secondThreeDigits = string.Join("", numbers.Skip(3).Take(3));
            var lastDigits = string.Join("", numbers.Skip(6));


            return $"({firstThreeDigits}) {secondThreeDigits}-{lastDigits}";

        }

    }
}