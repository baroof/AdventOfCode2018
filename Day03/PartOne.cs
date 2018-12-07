using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace DayThree
{
    class PartOne
    {
        public static int DisplayClaims(string[] input)
        {
            // "#1 @ 1,3: 4x4",
            // "#2 @ 3,1: 4x4",
            // "#3 @ 5,5: 2x2"};

            int bigWidth = 0;
            int bigHeight = 0;
            string pattern = @"#(\d+) @ (\d+),(\d+): (\d+)x(\d+)";
            Regex rx = new Regex(pattern);

            foreach (string line in input)
            {
                Console.WriteLine(line);
                Match m = rx.Match(line);
                while (m.Success)
                {
                    int id = int.Parse(m.Groups[1].Value);
                    int fromLeft = int.Parse(m.Groups[2].Value);
                    int fromTop = int.Parse(m.Groups[3].Value);
                    int width = int.Parse(m.Groups[4].Value);
                    int height = int.Parse(m.Groups[5].Value);

                    int testWidth = fromLeft + width;
                    int testHeight = fromTop + height;

                    if (testWidth > bigWidth)
                    {
                        bigWidth = testWidth;
                    }
                    if (testHeight > bigHeight)
                    {
                        bigHeight = testHeight;
                    }
                    m = m.NextMatch();
                }

                Console.WriteLine("bigWidth: {0}... bigHeight: {1}", bigWidth, bigHeight);
                
            }

            int[,] grid = new int[bigWidth+1, bigHeight+1];

            int countx = 0;
            // yes, again, dammit
            foreach (string line in input)
            {
                Console.WriteLine(line);
                Match m = rx.Match(line);
                while (m.Success)
                {
                    int id = int.Parse(m.Groups[1].Value);
                    int fromLeft = int.Parse(m.Groups[2].Value);
                    int fromTop = int.Parse(m.Groups[3].Value);
                    int width = int.Parse(m.Groups[4].Value);
                    int height = int.Parse(m.Groups[5].Value);

                    for (int i = 0; i < width; i++)
                    {
                        int x = fromLeft + i;
                        int y = fromTop;
                        if (grid[x, y] <= 0)
                        {
                            grid[x, y] = id;
                        }
                        else
                        {
                            countx++;
                        }
                    }

                    for (int i = 0; i < height; i++)
                    {
                        int x = fromLeft;
                        int y = fromTop + i;
                        if (grid[x, y] <= 0)
                        {
                            grid[x, y] = id;
                        }
                        else
                        {
                            countx++;
                        }
                    }
                    m = m.NextMatch();
                }
            }

            Console.WriteLine("countx: {0}", countx);
                    


            return 0;
        }
    }
}
