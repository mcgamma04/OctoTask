using System;
using System.Collections;

namespace OctoTask.algorithms
{
    public class SequenceCounter
    {
        public Hashtable FindSequenceCounter(int[] numArray)
        {
            int i =0;

            Hashtable result = new Hashtable();
           
            while (i < numArray.Length)
            {
                if (result.ContainsKey(numArray[i]))
                {
                    int counter = Convert.ToInt32(result[numArray[i]].ToString());
                    result.Remove(numArray[i]);
                    result.Add(numArray[i], counter);
                }
                else
                {
                    result.Add(numArray[i], 1);
                }

                i++;
            }

            return result;
        }

     
    }
}
