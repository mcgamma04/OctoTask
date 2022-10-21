using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace OctoTask.algorithms
{
    public class GetDuplicates
    {
        public GetDuplicates()
        {
        }

        public object[] FindDuplicates(int[] numArray)
        {
            List<int> sortedArray = numArray.ToList();
            sortedArray.Sort();
            ArrayList result = new ArrayList();
            
            for(int i=0; i < sortedArray.Count; i++)
            {
                for(int j=i+1; j < sortedArray.Count; j++)
                {
                    if(sortedArray[i] == sortedArray[j])
                    {
                        if (!result.Contains(sortedArray[i]))
                        {
                            result.Add(sortedArray[i]);
                        }
                        
                    }
                }
            }
            return result.ToArray();
        }
    }
}
