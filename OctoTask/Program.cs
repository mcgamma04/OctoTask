using System;
using System.Collections;
using System.Linq;
using OctoTask.algorithms;

namespace OctoTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Palidrone palidrone = new Palidrone();
            MinAndMaxNumber minAndMaxNumber = new MinAndMaxNumber();
            GetDuplicates getDuplicates = new GetDuplicates();
            SequenceCounter sequenceCounter = new SequenceCounter();

            //Console.WriteLine(palidrone.PaliTest("saippuakivikauppias"));
            //Console.WriteLine(minAndMaxNumber.FindMinAndMaxNumber(new int[] {5,4,346,98,2 }));
            //Console.WriteLine(getDuplicates.FindDuplicates(new int[] { 5, 4, 346, 98, 5,9,9,9, 2 }));
           Hashtable sequenceCheck = sequenceCounter.FindSequenceCounter(new int[] { 5, 4, 346, 98, 5, 9, 9, 9, 2 });

            foreach(DictionaryEntry entry in sequenceCheck){
                Console.WriteLine(entry.Value+": "+entry.Key);
            }
        }
    }
}
