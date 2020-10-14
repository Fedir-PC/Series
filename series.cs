using System;
class Program
{
    static void Main()
    {
        Series9();
    }

    static void Series1()
    {
        int[] a = new int[10] { 0, 1, 2, 3, 5, 6, 7, 8, 9, 10 };
        int sum = 0;
        for (int i = 0; i <= 9; i++)
            sum = sum + a[i];
        Console.WriteLine(sum);
    }

    static void Series3()
    {
        int[] a = new int[10] { 0, 1, 2, 3, 5, 6, 7, 8, 9, 10 };
        int sarf = 0, sum = 0;
        for (int i = 0; i <= 9; i++)
            sum = sum + a[i];
        sarf = sum / 10;
        Console.WriteLine(sarf);
    }

    static void Series5()
    {
        int N = 10, sum = 0;
        double[] a = new double[10] { 4.3, 1.5, 2, 3.6, 5, 6, 7.4, 8.9, 9.234, 10 };
        for (int i = 0; i <= 9; i++)
        {
            a[i] = Math.Truncate(a[i]);
            Console.WriteLine(a[i]);
            sum += (int)a[i];
        }
        Console.WriteLine(sum);
    }

    static void Series7()
    {
        int N = 10, sum = 0;
        double[] a = new double[10] { 4.3, 1.5, 2, 3.6, 5, 6, 7.4, 8.9, 9.234, 10 };
        for (int i = 0; i <= 9; i++)
        {
            a[i] = Math.Truncate(a[i]);
            Console.WriteLine(a[i]);
            sum += (int)a[i];
        }
        Console.WriteLine(sum);
    }

    static void Series9()
    {
        int N = 10, sum = 0, k = 0;
        double x = 0;
        int[] a = new int[10] { 4, 1, 2, 3, 5, 6, 7, 8, 9, 10 };
        for (int i = 0; i <= 9; i++)
        {
            x = a[i] % 2;
            if (x == 0)
            {
                Console.WriteLine(a[i]);
                k++;
            }
        }
        Console.WriteLine(k);
    }
}