using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet1
{
    internal class p5
    {
        public static void solve()
        {
            string file = @"C:\Users\anaaf.javed\source\repos\problemset1\p5.txt";
            string[] lines = File.ReadAllLines(file);
            int g = 0;
            int test = int.Parse(lines[g++]);

            for (int t = 1; t <= test; t++)
            {

                string[] line = lines[g++].Split(" ");
                int r = int.Parse(line[0]);
                int q = int.Parse(line[1]);
                double rep = (double)q / (double)r;

                if (rep % 1 != 0)
                {
                    System.Console.WriteLine("not possible");
                    continue;
                }
                else
                {
                    char[,] input_mat = new char[r, r];
                    int repeat = (int)rep;

                    for (int i = 0; i < r; i++)
                    {
                        char[] charArr = lines[g++].ToCharArray();
                        for (int j = 0; j < r; j++)
                        {
                            input_mat[i, j] = charArr[j];
                        }
                    }
                    char[,] outMat = new char[q, q];
                    int row = 0;
                    int col = 0;
                    int count_col = 0;
                    int count_row = 0;
                    for (int i = 0; i < r; i++)
                    {
                        row = count_row;
                        count_row = count_row + repeat;
                        count_col = repeat;
                        col = 0;
                        for (int j = 0; j < r; j++)
                        {
                            char temp = input_mat[i, j];
                            while (row < count_row)
                            {
                                while (col < count_col)
                                {
                                    outMat[row, col] = temp;
                                    col++;
                                }
                                col = count_col - repeat;
                                row++;
                            }
                            col = count_col;
                            count_col += repeat;
                            row = row - repeat;
                        }
                    }



                    for (int i = 0; i < outMat.GetLength(0); i++)
                    {
                        for (int j = 0; j < outMat.GetLength(1); j++)
                        {
                            System.Console.Write(outMat[i, j] + " ");
                        }
                        System.Console.WriteLine();
                    }

                }
            }
        }
    }
}
