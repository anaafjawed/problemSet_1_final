using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet1
{
    internal class p3
    {

        public static void solve() {

            string file = @"C:\Users\anaaf.javed\source\repos\problemset1\p3.txt";
            string[] lines = File.ReadAllLines(file);

            int g = 0; 

            HashSet<int> hs = new HashSet<int>();

            for (int t = 0; t < lines.Length; t++)
            {
                String str = lines[g++];
                String[] strArr = str.Split(" ");
                int[] arr = new int[strArr.Length];
                for (int i = 0; i < strArr.Length; i++)
                {
                    arr[i] = int.Parse(strArr[i]);
                }

                // implementation

                int n = arr.Length;

                for (int i = 1; i < arr.Length; i++)
                {
                    hs.Add(Math.Abs(arr[i] - arr[i - 1]));
                }

                Boolean isJolly = true;

                for (int i = 1; i < n; i++)
                {
                    if (!hs.Contains(i))
                    {
                        isJolly = false;
                    }
                }

                if (isJolly)
                {
                    System.Console.WriteLine("Jolly");
                }
                else
                {
                    System.Console.WriteLine("Not Jolly");
                }


            }
        }
    }
}
