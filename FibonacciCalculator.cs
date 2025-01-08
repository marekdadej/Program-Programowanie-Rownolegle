using System;

namespace IntegrationTasks
{
    public class FibonacciCalculator
    {
        public void GenerateFibonacci(int numElements)
        {
            int[] fibonacciSeries = new int[numElements];
            fibonacciSeries[0] = 0;
            if (numElements > 1)
            {
                fibonacciSeries[1] = 1;
            }

            for (int i = 2; i < numElements; i++)
            {
                fibonacciSeries[i] = fibonacciSeries[i - 1] + fibonacciSeries[i - 2];
            }

            Console.WriteLine("Ciąg Fibonacciego:");
            foreach (int element in fibonacciSeries)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}