using System;

namespace IntegrationTasks
{

    public class QuadraticIntegration
    {
        public double CalculateTrapezoid(double a, double b, double c, double xStart, double xEnd, int n)
        {
            double dx = (xEnd - xStart) / n;
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                double x0 = xStart + i * dx;
                double x1 = xStart + (i + 1) * dx;
                sum += (Function(x0, a, b, c) + Function(x1, a, b, c)) * dx / 2;
            }

            return sum;
        }

        private double Function(double x, double a, double b, double c)
        {
            return a * x * x + b * x + c;
        }
    }
}