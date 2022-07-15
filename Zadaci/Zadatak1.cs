/*
Your function takes two arguments:

current father's age (years)
current age of his son (years)
Сalculate how many years ago the father was twice as old as his son (or in how many years he will be twice as old).

*/

    public class TwiceAsOldSolution
    {
        public static int TwiceAsOld(int dadYears, int sonYears)
        {
           // Add you code here .
           var result = dadYears - (sonYears * 2);


            return Math.Abs(result);

        }
    }
