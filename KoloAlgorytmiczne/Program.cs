using System;

namespace KoloAlgorytmiczne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyPow(2.0, -2147483648));
        }

        static double MyPow(double x, long n)
        {
            if (n == 0)
            {
                return 1;
            }

            if (n < 0)
            {
                n *= -1;
                x = 1 / x;
            }

            if (n % 2 == 0)
            {
                return MyPow(x * x, n / 2);
            }
            else
            {
                return x * MyPow(x * x, n / 2);
            }
        }
    }
}
