using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;

            int c;
            int f;

            c = ++a + ++b;
            f = a-- + b--;

            Console.WriteLine(c);
            Console.WriteLine(f);
        }
    }
}
