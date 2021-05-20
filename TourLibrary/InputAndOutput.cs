using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourLibrary
{
    public class Input
    {
        public static int NonNegative()
        {
            var input = int.Parse(Console.ReadLine());
            if (input < 0)
            {
                throw new LessThenZeroException("The amount can't be less then zero!");
            }
            return input;
        }

        public static int InBound(int bound)
        {
            int input = int.Parse(Console.ReadLine());
            if (input < 1 || input > bound)
            {
                throw new OutOfBoundaries("Out of boundaries!");
            }
            return input;
        }
    }

    public class Output
    {
        public static void Print(string message)
        {
            ConsoleColor temp = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(string.Format("\n" + "{0," + ((Console.WindowWidth / 2) + (message.Length / 2)) + "}", message + "\n"));
            Console.ForegroundColor = temp;
        }
        public static void Title(string title)
        {
            ConsoleColor temp = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(string.Format("\n" + "{0," + ((Console.WindowWidth / 2) + (title.Length / 2)) + "}", title + "\n\n"));
            Console.ForegroundColor = temp;
        }
    }
}
