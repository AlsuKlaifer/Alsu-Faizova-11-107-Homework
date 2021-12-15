using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Extension
{
    public static class StringExtension
    {
        public static string OneByOneJoin(this string s1, string s2)
        {
            string[] str1 = s1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] str2 = s2.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string s = null;
            for (int i = 0; i < Math.Min(str1.Length, str2.Length); i++)
            {
                s += str1[i] + ' ' + str2[i] + ' ';
            }
            for (int i = Math.Min(str1.Length, str2.Length); i < Math.Max(str1.Length, str2.Length); i++)
                if (Math.Max(str1.Length, str2.Length) == str1.Length)
                    s += str1[i] + ' ';
                else s += str2[i] + ' ';
            return s;
        }

        public static void Rainbow(this String input)
        {

            ConsoleColor[] colors = new ConsoleColor[]
            { ConsoleColor.Red,
              ConsoleColor.Yellow,
              ConsoleColor.Green,
              ConsoleColor.Blue,
              ConsoleColor.DarkBlue,
              ConsoleColor.Magenta
            };
            int color_index = 0; // from 0 to 5

            string[] str = input.Split(' ');

            foreach (var el in str)
            {
                Console.ForegroundColor = colors[color_index];
                Console.Write($"{el} ");
                color_index++;
                color_index %= 6;
            }
        }
    }
}
