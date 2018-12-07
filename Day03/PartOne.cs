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
                //Console.WriteLine(line);
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

            // make the 2d array one tick larger for padding around the claims
            int gridWidth = bigWidth + 1;
            int gridHeight = bigHeight + 1;
            object[,] grid = new object[gridWidth, gridHeight];
            
            // pre-populate the whole grid with 0s
            for (int m = 0; m < gridWidth; m++)
            {
                for (int n = 0; n < gridHeight; n++)
                {
                    grid[m, n] = 0;
                }
            }

            int countx = 0;

            // go through it all again to populate the grid
            foreach (string line in input)
            {
                //Console.WriteLine(line);
                Match m = rx.Match(line);
                while (m.Success)
                {
                    int id = int.Parse(m.Groups[1].Value);
                    int fromLeft = int.Parse(m.Groups[2].Value);
                    int fromTop = int.Parse(m.Groups[3].Value);
                    int width = int.Parse(m.Groups[4].Value);
                    int height = int.Parse(m.Groups[5].Value);

                    for (int x = fromLeft; x < (fromLeft + width); x++)
                    {
                        for (int y = fromTop; y < (fromTop + height); y++)
                        {
                            if (object.Equals(grid[x, y],0))
                            {
                                grid[x, y] = id;
                            }
                            else
                            {
                                grid[x, y] = "#";
                                countx++;
                            }
                        }
                    }

                    m = m.NextMatch();
                }
            }


            Console.WriteLine("countx: {0}", countx);

            for (int i = 0; i < gridWidth; i++)
            {
                for (int j = 0; j < gridHeight; j++)
                {
                    Console.Write(string.Format("{0} ", grid[i, j]));
                }
                Console.Write(Environment.NewLine);// + Environment.NewLine);
            }
            //Console.ReadLine();

            return 0;
        }
    }
}
