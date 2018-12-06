using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace DayTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //PartOne.RunTests();

            string[] testinput = {
                "abcde",
                "fghij",
                "klmno",
                "pqrst",
                "fguij",
                "axcye",
                "wvxyz"};

            PartTwo.FindTheBoxes(testinput);
            string[] input = System.IO.File.ReadAllLines(args[0]);
            PartTwo.FindTheBoxes(input);

            //PartOne.GetBrutal(input);

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
