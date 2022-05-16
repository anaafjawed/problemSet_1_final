using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet1
{
    internal class p1
    {
        public static void solve()
        {
            string file = @"C:\Users\anaaf.javed\source\repos\problemset1\p1.txt";
            string[] lines = File.ReadAllLines(file);
            int g = 0;
            bool end = false;
            while (!end) {
                String[] strArr = lines[g++].Split(" ");

                double a = double.Parse(strArr[0]);
                double b = double.Parse(strArr[1]);
                double c = double.Parse(strArr[2]);

                if (a == 0 & b == 0 && c == 0) {
                    end = true;
                    continue;
                }

                double sq_a = Math.Pow(a, 2);
                double sq_b = Math.Pow(b, 2);
                double sq_c = Math.Pow(c, 2);

                if (sq_a == sq_b + sq_c || sq_b == sq_a + sq_c || sq_c == sq_a + sq_b)
                {
                    System.Console.WriteLine("right");
                }
                else
                {
                    System.Console.WriteLine("wrong");
                }

            }

        }
        }
    }
