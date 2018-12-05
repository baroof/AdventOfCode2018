using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace DayTwo
{
    public class PartOne
    {
        //TESTS
        public static int RunTests()
        {
            string[] testinput = {
                            "dddddd",  //expect: no matches
                            "abcdef",  //expect: no matches
                            "bababc",  //expect: both (counts twice, for two a and three b)
                            "abbcde",  //expect: two only (b)
                            "abcccd",  //expect: three only (c)
                            "aabcdd",  //expect: two only (a & d, but only counts once)
                            "abcdee",  //expect: two only (e)
                            "ababab" };//expect: three only (a & b, but only counts once)
            //string pattern = "abc";
            string basicpattern = @"(?<first>\w{1}).*(\k<first>)";

            string twopattern = @"(?<first>\w{1})\w*(\k<first>){1}?"; //https://docs.microsoft.com/en-us/dotnet/standard/base-types/regular-expression-language-quick-reference#quantifiers       

            string threepattern = @"(?<first>\w{1})(.*(\k<first>)){2,2}";

            Regex rxbasic = new Regex(basicpattern);
            Regex rxtwo = new Regex(twopattern);
            Regex rxthree = new Regex(threepattern);

            //TestMatches(testinput, rxbasic, "basic");
            //TestMatches(testinput, rxtwo, "twos");
            //TestMatches(testinput, rxthree, "threes");

            GetBrutal(testinput);
            return 0;
        }

        private static void TestMatches(string[] testinput, Regex rx, string label)
        {
            Console.WriteLine("#### testing for " + label + " matches:");
            foreach (string line in testinput)
            {
                Match result = rx.Match(line);
                while (result.Success)
                {
                    Console.WriteLine("Line: {0}, Match: {1}", line, result.Value);
                    result = result.NextMatch();
                }
            }
        }

        private static void GetBrutal(string[] input)
        {
            foreach (string line in input)
            {
                Hashtable letterCounts = new Hashtable();


                foreach (char letter in line)
                {
                    try
                    {
                        letterCounts.Add(letter, 1);
                        Console.WriteLine("first time for " + letter + "... added...");
                    }
                    catch
                    {
                        letterCounts[letter] = (int)letterCounts[letter] + 1;
                        Console.WriteLine("already seen " + letter + "! Incremented...");

                    }

                    Console.WriteLine("now on letter: " + letter + " in line: " + line + "... count is at: " + letterCounts[letter] );

               
                }
            }
        }
    }
                

}
