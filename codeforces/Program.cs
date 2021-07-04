using System;
using System.Collections.Generic;
using System.Linq;

namespace codeforces
{
    class Program
    {
        static List<int> l = new List<int>();
        static int max = 0;
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var list = str.Split(" ");
            var n = int.Parse(list[0]); 
            var a = int.Parse(list[1]); 
            var b = int.Parse(list[2]); 
            var c = int.Parse(list[3]);

            l = new List<int>() {a, c, b };
            l.Sort();
            if (n % l[0] == 0)
            {
                Console.WriteLine(n / l[0]);
                return;
            }

            dfs(n, 0);
            Console.WriteLine(max);

        }
        static void dfs(int n, int count) 
        {
            if (n < 0)
                return;

            if (n == 0) 
            {
                max = Math.Max(max, count);
                return;
            }

            dfs(n - l[0], count+1);
            dfs(n - l[1], count+1);
            dfs(n - l[2], count+1);
        }
    }
}