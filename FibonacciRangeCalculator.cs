using System;

namespace IntegrationTasks
{
    public class FibonacciRangeCalculator
    {
        public void DisplayFibonacciRange(int start, int count)
        {
            if (start < 0 || count <= 0)
            {
                Console.WriteLine("Indeks początkowy musi być nieujemny, a ilość elementów większa od zera.");
                return;
            }

            int[] fibonacci = new int[start + count];
            fibonacci[0] = 0;
            if (start + count > 1)
            {
                fibonacci[1] = 1;
                for (int i = 2; i < start + count; i++)
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }
            }

            Console.WriteLine($"Wyświetlanie {count} elementów ciągu Fibonacciego od indeksu {start}:");
            for (int i = start; i < start + count; i++)
            {
                Console.Write(fibonacci[i] + " ");
            }
            Console.WriteLine();
        }
    }
}