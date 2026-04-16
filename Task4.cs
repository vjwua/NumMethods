using System;
using System.Collections.Generic;
using System.Text;

public class Task4
{
    static public (double k, double b) ComputeCoefficients(double[] x, double[] y)
    {
        int n = x.Length;
        double sumX = 0, sumY = 0, sumXY = 0, sumX2 = 0;

        for (int i = 0; i < n; i++)
        {
            sumX += x[i];
            sumY += y[i];
            sumXY += x[i] * y[i];
            sumX2 += x[i] * x[i];
        }

        double k = (n * sumXY - sumX * sumY) / (n * sumX2 - sumX * sumX);
        double b = (sumY - k * sumX) / n;

        return (k, b);
    }

    static public double Predict(double x, double k, double b) => k * x + b;

    static public double ComputeR2(double[] x, double[] y, double k, double b)
    {
        int n = y.Length;
        double yMean = 0;
        for (int i = 0; i < n; i++) yMean += y[i];
        yMean /= n;

        double ssTot = 0, ssRes = 0;
        for (int i = 0; i < n; i++)
        {
            ssTot += Math.Pow(y[i] - yMean, 2);
            ssRes += Math.Pow(y[i] - Predict(x[i], k, b), 2);
        }

        return 1.0 - ssRes / ssTot;
    }

    static public void PrintSummary(double k, double b, double r2)
    {
        Console.WriteLine("=== Linear regression in = kx + b ===");
        Console.WriteLine();
        Console.WriteLine($"  k        = {k:F4}");
        Console.WriteLine($"  b        = {b:F4}");
        Console.WriteLine($"  Equation : y = {k:F4}x + ({b:F4})");
        Console.WriteLine($"  R^2      = {r2:F4}");
        Console.WriteLine();
    }

    static public void PrintComparisonTable(double[] x, double[] y, double k, double b)
    {
        Console.WriteLine("=== Value comparison ===");
        Console.WriteLine($"{"x",-2} {"y (fact)",10} {"y (model)",12} {"deviation",12}");
        Console.WriteLine(new string('-', 50));

        for (int i = 0; i < x.Length; i++)
        {
            double yPred = Predict(x[i], k, b);
            double delta = y[i] - yPred;
            Console.WriteLine($"{x[i],-2} {y[i],10:F2} {yPred,12:F4} {delta,12:F4}");
        }
    }
}
