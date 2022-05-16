using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet1
{
    internal class p2
    { 
        static int n;
        static char[,] mineMat;

        public static void solve()
        {

            string file = @"C:\Users\anaaf.javed\source\repos\problemset1\p2.txt";

            string[] lines = File.ReadAllLines(file);
            int g = 0;
            n = int.Parse(lines[g++]);

            mineMat = new char[n, n];
            char[,] clicks = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                char[] temp = lines[g++].ToCharArray();
                for (int col = 0; col < temp.Length; col++)
                {
                    mineMat[row, col] = temp[col];
                }
            }

            for (int row = 0; row < n; row++)
            {
                char[] temp = lines[g++].ToCharArray();
                for (int col = 0; col < temp.Length; col++)
                {
                    clicks[row, col] = temp[col];
                }
            }

            bool isExposed = false;

            int diff = 1;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    int count = 0;
                    if (!isExposed)
                    {
                        if (clicks[row, col] == 'x' && mineMat[row, col] == '*')
                        {
                            isExposed = true;
                        }
                        else if (clicks[row, col] == 'x' && mineMat[row, col] == '.')
                        {

                            // all possible commbinations to check the mines in n * n grid

                            // diff the factor by which we have to check the mines, can be changed to any other number 

                            count = check(row + diff, col) + // down
                                check(row + diff, col - diff) + // left to down square
                                check(row + diff, col + diff) + // right to down square
                                check(row - diff, col) +       // up
                                check(row - diff, col - diff) +  // left to up square 
                                check(row - diff, col + diff) + // right to up square
                                check(row, col + diff) +    // right
                                check(row, col - diff);     // left



                            Console.Write(count);

                        }
                        else if (clicks[row, col] == '.')
                        {

                            Console.Write('.');

                        }

                    }
                    else
                    {

                        Console.WriteLine(mineMat[row, col]);
                    }

                }
                Console.WriteLine();
            }

        }

        public static int check(int x, int y)
        {
            // checking that the rows and columns are in bound then checking the mine exist or not  

            if (x >= 0 && x < n && y >= 0 && y < n)
            {
                if (mineMat[x, y] == '*')
                {
                    return 1;
                }
                else
                {

                    return 0;
                }
            }
            else
            {
                return 0;
            }

        }

    }
}
