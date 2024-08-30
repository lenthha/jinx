using System;

class Program
{
    const int ARRAY_SIZE = 100000;
    const long MIN = -9223372036854775807;
    const long MAX = 9223372036854775807;

    static void Input(long[] a, long size)
    {
        for (int i = 0; i < size; ++i)
        {
            a[i] = long.Parse(Console.ReadLine());
        }
    }

    static void Output(long[] a, long size)
    {
        for (int i = 0; i < size; ++i)
        {
            Console.Write(a[i] + " ");
        }
    }

    static long MaxFinder(long[] a, long size)
    {
        long max = MIN;
        for (int i = 0; i < size; ++i)
        {
            if (a[i] > max)
            {
                max = a[i];
            }
        }
        return max;
    }

    static long MinFinder(long[] a, long size)
    {
        long min = MAX;
        for (int i = 0; i < size; ++i)
        {
            if (a[i] < min)
            {
                min = a[i];
            }
        }
        return min;
    }

    static void ZeroFill(long[] zero, long size)
    {
        for (int i = 0; i < size; ++i)
        {
            zero[i] = 0;
        }
    }

    static void CountingSort(long[] vec, long len, long min, long max)
    {
        int[] cnt = new int[max - min + 1];

        for (long i = min; i <= max; ++i)
        {
            cnt[i - min] = 0;
        }
        for (long i = 0; i < len; ++i)
        {
            ++cnt[vec[i] - min];
        }

        for (long i = min; i <= max; ++i)
        {
            for (int j = cnt[i - min]; j-- > 0;)
            {
                vec[--len] = i;
            }
        }
    }

    static void Main()
    {
        long[] mainArray = new long[ARRAY_SIZE];
        long[] zero = new long[ARRAY_SIZE];
        long size = long.Parse(Console.ReadLine());
        Input(mainArray, size);
        ZeroFill(zero, size);
        long max = MaxFinder(mainArray, size);
        long min = MinFinder(mainArray, size);
        CountingSort(mainArray, size, min, max);
        Output(mainArray, size);
    }
}
