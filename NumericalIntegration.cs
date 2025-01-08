using System;

namespace IntegrationTasks
{
    public class NumericalIntegration
    {
        public double CalculateRectangle(double a, double b, int n)
        {
            double dx = (b - a) / n;
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                double x = a + i * dx;
                sum += Function(x) * dx;
            }

            return sum;
        }

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
            return 0.5 * x;
        }
    }
}