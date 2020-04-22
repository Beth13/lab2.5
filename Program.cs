using System;

namespace lab2._5

{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Enter n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter m");
            int m = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, m];
            Console.WriteLine("Enter your array");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());

                }

            }
            Console.WriteLine("Your array");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write("\t" + arr[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine("New array");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i + j == n - 1)
                    {
                        arr[i, j] = 0;
                    }
                    if ((i + j < n - 1) || (i + j > n - 1))
                    {
                        arr[i, j] *= arr[i, j];
                    }

                }

            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write("\t" + arr[i, j]);
                Console.WriteLine();
            }

        }
    }
}
