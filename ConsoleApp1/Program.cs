using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOne
{
    class Program
    {
        static void Main(string[] args)
        {   

            // initial frequency of 0
            int freq = 0;

            // store frequencies as they are calculated, including initial freq
            List<int> freqs = new List<int>
            {
                freq
            };

            //gather the inputs
            string[] input = System.IO.File.ReadAllLines(args[0]);

            //solution 2, keep looping on input until freq match is found
            int loops = 0;
            while (true)
            {
                foreach (string line in input)
                {
                    //Console.WriteLine("input: " + line);
                    freq += int.Parse(line);
                    //Console.WriteLine("\t freq now: " + freq);

                    //solution 2 loop
                    if (freqs.Contains(freq))
                    {
                        Console.WriteLine("Found recurrance of freq: " + freq);
                        System.Environment.Exit(0);
                       
                    }
                    else
                    {
                        freqs.Add(freq);
                    }
                }

                Console.WriteLine("Loop " + loops + " complete. freqs[] now contains " + freqs.Count + " elements");
                loops++;
                //Console.WriteLine("press any key to continue");
                //Console.ReadKey();
            }
            //solution 1 solve:
            //Console.WriteLine("final freq: " + freq);

            Console.WriteLine("press any key to exit");
            Console.ReadKey();

        }
    }
}
