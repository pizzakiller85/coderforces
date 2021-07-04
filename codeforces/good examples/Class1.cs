
using System;

class Program
{
    static void Main_two()
    {
        int cases = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < cases; i++)
        {
            string s = Console.ReadLine();

            if (s.Length > 10)
                s = $"{s[0]}{s.Length - 2}{s[s.Length - 1]}";

            Console.WriteLine(s);
        }
    }



}