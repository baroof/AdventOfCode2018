using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace DayThree
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] testinput = {
                "#1 @ 1,3: 4x4",
                "#2 @ 3,1: 4x4",
                "#3 @ 5,5: 2x2"};

            PartOne.DisplayClaims(testinput);

            //string[] input = System.IO.File.ReadAllLines(args[0]);
            //PartTwo.___(input);

        }
    }
}
