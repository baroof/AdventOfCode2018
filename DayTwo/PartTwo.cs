using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTwo
{
    class PartTwo
    {
        public static int FindTheBoxes(string[] input)
        {


            //iterate through all the strings, one by one
            for (int i = 0; i < input.Length; i++)
            {
                char[] candidate = input[i].ToCharArray();
                // 
                // Console.WriteLine("on candidate: " + candidate);
                //

                // iterate through all the strings from this candidate forward, comparing as we go
                for (int j = i+1; j < input.Length; j++)
                {
                    char[] candidatePlusOne = input[j].ToCharArray();
                    //
                    // Console.WriteLine("on candidatePlusOne: " + candidatePlusOne);
                    //

                    int mismatchCounter = 0;
                    int mismatchLetter = 0;
                    List<string> mismatches = new List<string>();

                    //iterate through each letter, counting up mismatches (finding just 1 == winner!)
                    for (int k = 0; k < candidate.Length; k++)
                    {
                        //
                        // Console.WriteLine("on candidate[k]: " + candidate[k] + " and candidatePlusOne[k]: " + candidatePlusOne[k]);
                        //
                        if (candidate[k] != candidatePlusOne[k])
                        {
                            //
                            // Console.WriteLine("looks like a mismatch!");
                            //
                            mismatchCounter++;
                            mismatchLetter = k;
                            mismatches.Add(candidate[k].ToString());
                            mismatches.Add(candidatePlusOne[k].ToString());
                        }
                    }

                    if (mismatchCounter == 1)
                    {
                        Console.WriteLine("got a hit: " + input[i] + " mismatched one letter in: " + input[j]);
                        //mismatches.ForEach(Console.WriteLine);
                        StringBuilder result = new StringBuilder(input[i]);
                        result.Remove(mismatchLetter, 1);
                        Console.WriteLine("result: " + result.ToString());

                    }
                }
            }
            return (0);
        }
    }
}
