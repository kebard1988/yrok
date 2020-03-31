using System;

namespace yrok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Free(33));
            Console.ReadKey();
        }

        static int Free(int feet)
        {
            int inches = feet * 12;
            return inches;
        }
    }
}
