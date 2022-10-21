using System;
using System.Linq;

namespace OctoTask.algorithms
{
    public class Palidrone
    {
        public Palidrone()
        {


        }

        public Boolean PaliTest(string word)
        {
            char[]  wordArray = word.ToArray();

            int start = 0;
            int end = wordArray.Length -1;
            while (start < wordArray.Length)
            {

                if (wordArray[start].Equals(wordArray[end]))
                {
                    return true;
                }
                else { return false; }

                start++;
                end--;
            }


            return false;
        }
    }
}
