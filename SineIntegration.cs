using System;

namespace IntegrationTasks
{

    public class SineIntegration
    {
        public double CalculateTrapezoid(double a, double b, int n)
        {
            double dx = (b - a) / n;
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                double x0 = a + i * dx;
                double x1 = a + (i + 1) * dx;
                sum += (Function(x0) + Function(x1)) * dx / 2;
            }

            return sum;
        }

        private double Function(double x)
        {
            return Math.Sin(x);
        }
    }
}