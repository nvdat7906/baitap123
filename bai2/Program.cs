using System;

class Bai2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine().Trim());

        string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(input[i]);
        }

        Array.Sort(a);

        int max1 = a[n - 1]; 
        int max2 = 0;
        bool timThay = false;

        for (int i = n - 2; i >= 0; i--)
        {
            if (a[i] < max1)
            {
                max2 = a[i];
                timThay = true;
                break;
            }
        }

        if (timThay)
        {
            Console.WriteLine($"{max1} {max2}");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}