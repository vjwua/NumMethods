using System;
using System.Collections.Generic;
using System.Text;

public class Task2
{
    const double precision = 0.0001f;
    static public void Jacobi(double x, double y, double z)
    {
        double xNew = 0, yNew = 0;

        int iterations = 0;

        while (true)
        {
            xNew = 1.0 / 3 + y / 3;
            yNew = (1 + x) / 3;
            iterations++;

            Console.WriteLine($"k={iterations + 1}: x={xNew:F6}, y={yNew:F6}");

            if(xNew - x < precision && yNew - y < precision)
            {
                break;
            }

            x = xNew;
            y = yNew;
        };
    }

    static public void Gauss(double x, double y, double z)
    {
        int iterations = 10;

        for (int i = 0; i < iterations; i++)
        {
            x = 1.0 / 3 + y / 3;
            y = (1 + x) / 3;

            Console.WriteLine($"k={i + 1}: x={x:F6}, y={y:F6}");
        }
    }
}