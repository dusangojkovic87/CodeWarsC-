using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codewars.Zadaci
{
    public static class FindUnique
    {
        public static int Get(IEnumerable<int> numbers)
        {
            List<int> numList = new List<int>(numbers);
            int count = 0;



            for (int i = 0; i < numList.Count; i++)
            {
                count = numList.Count(x => x == numList[i]);
                if (count == 1)
                {
                    return numList[i];
                }

                continue;


            }



            return 0;
        }

    }
}