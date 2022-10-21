using System;
using System.Linq;

namespace OctoTask.algorithms
{
    public class MinAndMaxNumber
    {
        public MinAndMaxNumber()
        {
        }

        public string FindMinAndMaxNumber(int[] numArray)
        {
            int min = numArray.Min();
            int max = numArray.Max();
            return "{"+min+", "+max+"}";
        }
    }
}
