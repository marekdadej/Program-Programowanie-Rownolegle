using System;

namespace IntegrationTasks.RectangleIntegration
{
    public class RectangleIntegration2
    {
        private double Function(double x)
        {
            return 0.5 * x;
        }

        public double CalculateIntegral(double a, double b, int n)
        {
            double deltaX = (b - a) / n;
            double integral = 0.0;

            for (int i = 0; i < n; i++)
            {
                double x = a + i * deltaX;
                integral += Function(x) * deltaX;
            }

            return integral;
        }
    }
}