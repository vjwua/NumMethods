using System;
using System.Collections.Generic;
using System.Text;
public class Task1
{
    static public double Example1(int a, int x0)
    {
        return Example3(a, x0, 2);
    }
    static public double Example2(int a, int x0)
    {
        return Example3(a, x0, 3);
    }
    static public double Example3(int a, int x0, int n)
    {
        double xc = x0;
        double xn = 0;
        while (true)
        {
            double partA = (double)1 / n;
            double partB = (n - 1) * (xc);
            double partC = a / Math.Pow(xc, n - 1);
            xn = partA * (partB + partC);
            
            if (Math.Abs(xn - xc) < 0.001)
                return xn;

            xc = xn;
        }
    }
}