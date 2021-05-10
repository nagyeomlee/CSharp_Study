using System;

namespace May10_16
{
    class Program
    {
        public static void Main(string[] args)
        {
            int result = Ma.Plus(1, 2);
            Console.WriteLine(result);
            int result2 = Print.Do();
            Console.WriteLine(result2);
        }
    }

    class Ma
    {
        public static int Plus(int a, int b)
        {
            int result = a + b;
            return result;
        }
    }
    class Print
    {
        public static int Do()
        {
            Console.WriteLine(Ma.Plus(3, 4));
            return Ma.Plus(3, 4);
        }
    }
}
