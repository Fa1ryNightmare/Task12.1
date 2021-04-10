using System;

namespace Task12_1
{
    class Program
    {
        static void Main()
        {
            Func<bool> func = null;
            func += F;

            Action<Func<bool>, string, int> myDel = null;
            myDel += ((a, b, c) =>
                Console.WriteLine($"{a}\t{b}\t{c}")
            );

            myDel += ((a, b, c) =>
                Console.WriteLine($"{a}\t{b}\t{c}")
            );

            myDel(func, "ABOBA", 5);
        }
        static bool F()
        {
            return false;
        }
    }
}
