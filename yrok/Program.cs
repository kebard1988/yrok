using System;

namespace yrok
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5 * 6;

            Console.WriteLine(x);
            Console.ReadKey();
        }

        static int Free(int feet)
        {
            int inches = feet * 12;
            return inches;
        }
    }
}
