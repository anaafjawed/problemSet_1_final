using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet1
{
    internal class p4
    {

        public static void solve()
        {

            string file = @"C:\Users\anaaf.javed\source\repos\problemset1\p4.txt";

            string[] lines = File.ReadAllLines(file);
            int t = 0;
            int test = Int32.Parse(lines[t]);
            t++;

            for (int i = 0; i < test; i++)
            {
                int friendships_count = Int32.Parse(lines[t]);
                t++;

                string[] friends = new string[friendships_count];

                // storing friendship

                for (int j = 0; j < friendships_count; j++)
                {
                    friends[j] = lines[t];
                    t++;
                }


                ArrayList network = new ArrayList();

                network.Add(new HashSet<String>());

                for (int j = 0; j < friends.Length; j++)
                {
                    string[] temp = friends[j].Split(" ");
                    Boolean isFound = false;
                    foreach (HashSet<String> net in network)
                    {
                        HashSet<String> hs = net;
                        if (hs.Contains(temp[0]))
                        {
                            hs.Add(temp[1]);
                            System.Console.WriteLine(hs.Count);
                            isFound = true;
                        }
                        else if (hs.Contains(temp[1]))
                        {
                            hs.Add(temp[0]);
                            System.Console.WriteLine(hs.Count);
                            isFound = true;
                        }
                    }

                    if (!isFound)
                    {
                        HashSet<String> newHs = new HashSet<String>();
                        newHs.Add(temp[0]);
                        newHs.Add(temp[1]);
                        network.Add(newHs);
                        System.Console.WriteLine(newHs.Count);
                    }
                }

            }
        }
    }
}
