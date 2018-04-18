using System;
using System.Collections.Generic;
using System.Text;

namespace Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            char from = 'A', to = 'B', help = 'C';

            do
            {
                try
                {
                    Console.Write("  input number of disk: ");
                    x = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    x = -10;
                }
            } while (x == -10 || x > 10);
            Console.WriteLine("\n  from = A, to = B, help = C\n");
            hanoi(x, from, to, help);

            Console.Read();
        }

        static void hanoi(int x, char from, char to, char help)
        {
            if (x > 0)
            {
                hanoi(x - 1, from, help, to);
                move(x, from, to);
                hanoi(x - 1, help, to, from);
            }

        }

        static void move(int x, char from, char to)
        {
            Console.WriteLine("  move disk " + x + " from " + from + " to " + to);
        }

    }
}