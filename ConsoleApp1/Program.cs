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
            string[] input = System.IO.File.ReadAllLines(args[0]);

            int freq = 0;

            foreach (string line in input)
            {
                Console.WriteLine("input: " + line);
                freq += int.Parse(line);
                Console.WriteLine("\t freq now: " + freq);
            }

            Console.WriteLine("final freq: " + freq);
            Console.WriteLine("press any key to exit");
            Console.ReadKey();

        }
    }
}
