using System;

namespace IntegrationTasks.RectangleIntegration
{
    public class RectangleIntegration3
    {
        private double Function(double x)
        {
            return 0.5 * x;
        }

        public double CalculateLeftIntegral(double a, double b, int n)
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

        public double CalculateRightIntegral(double a, double b, int n)
        {
            double deltaX = (b - a) / n;
            double integral = 0.0;

            for (int i = 1; i <= n; i++)
            {
                double x = a + i * deltaX;
                integral += Function(x) * deltaX;
            }

            return integral;
        }

        public double CalculateMidIntegral(double a, double b, int n)
        {
            double deltaX = (b - a) / n;
            double integral = 0.0;

            for (int i = 0; i < n; i++)
            {
                double x = a + (i + 0.5) * deltaX;
                integral += Function(x) * deltaX;
            }

            return integral;
        }
    }
}