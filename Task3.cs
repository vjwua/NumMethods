using System;
using System.Collections.Generic;
using System.Text;

public class Task3
{
    static public double Lagrange(double[] xValues, double[] yValues, double x)
    {
        int n = xValues.Length;
        double result = 0.0;

        for (int i = 0; i < n; i++)
        {
            double term = yValues[i];

            for (int j = 0; j < n; j++)
            {
                if (j != i)
                {
                    term *= (x - xValues[j]) / (xValues[i] - xValues[j]);
                }
            }

            result += term;
        }

        return result;
    }
}
