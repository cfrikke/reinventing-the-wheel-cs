using System;
namespace UtilityPackageArray
{

    class ArrayUtils
    {
        public static void Main()
        {
            int[] Avg = { 1, 2, 5, 10, 25 };
            Console.WriteLine(Average(Avg));

            int[] max = { 1, 6, 9, 16, 19, 27 };
            Console.WriteLine(Max(max));

            int[] min = { 32, 54, 78, 88, 227 };
            Console.WriteLine(Min(min));
        }

        public static int Average(int[] a)
        {
            int avg = 0;
            for (int i = 0; i < a.Length; i++)
            {
                avg += a[i];
            }
            return avg / a.Length;
        }
        public static int Max(int[] b)
        {
            int max = b[0];
            for (int i = 1; i < b.Length; i++)
            {
                if (b[i] > max)
                    max = b[i];
            }

            return max;
        }
        public static int Min(int[] c)
        {
            int min = c[0];

            for (int i = 0; i < c.Length; i++)
            {
                int C = c[i];

                if (C < min) {
                    min = C;
                }
            }
            return min;

        }

    }


}