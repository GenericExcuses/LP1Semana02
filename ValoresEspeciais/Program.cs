using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {

            double x = double.NegativeInfinity;
            double y = double.PositiveInfinity;

            double max = double.MaxValue;
            double min = double.MinValue;

            float maxFloat = float.MaxValue;
            float minFloat = float.MinValue;

            float z = float.NaN;

            int maxInt = int.MaxValue;
            int minInt = int.MinValue;

            int i = short.MaxValue;

            sbyte sb = sbyte.MaxValue;
            sbyte sa = sbyte.MinValue;

            double p = 2 * double.MaxValue;
            float f1 , f2 ;
            f1 = f2 = 10000.0f;

            ulong lu = ulong.MinValue;
            ulong ul = ulong.MaxValue;

            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(maxInt);
            Console.WriteLine(minInt);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(p);
            Console.WriteLine(f1 == f2 + 0.0001f);
            Console.WriteLine((short) ( i + 1));
            Console.WriteLine(maxFloat);
            Console.WriteLine(minFloat);
            Console.WriteLine(sa);
            Console.WriteLine(sb);
            Console.WriteLine(lu);
            Console.WriteLine(ul);
        }
    }
}
