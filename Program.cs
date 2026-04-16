class Program
{
    const int a = 69;
    const int x0 = 23;

    static void Main(string[] args)
    {
        Console.WriteLine($"Result for square root of {a}: {Task1.Example1(a, x0):F4}");
        Console.WriteLine($"Result for cubic root of {a}: {Task1.Example2(a, x0):F4}");
        for (int n = 4; n < 10; n++)
        {
            Console.WriteLine($"Result for {n} root of {a}: {Task1.Example3(a, x0, n):F4}");
        }
        Console.WriteLine(new string('-', 50));
        Task2.Jacobi(0.0, 0.0, 0.0);
        Console.WriteLine(new string('-', 50));
        Task2.Gauss(0.0, 0.0, 0.0);
        Console.WriteLine(new string('-', 50));
        double[] xValues = { 1, 2, 3, 4, 5 };
        double[] yValues = { 3, 6, 7, 8, 12 };

        for (int i = 0; i < xValues.Length; i++)
        {
            double y = Task3.Lagrange(xValues, yValues, xValues[i]);
            Console.WriteLine($"x = {xValues[i]}, y = {y}");
        }
        Console.WriteLine(new string('-', 50));
        for (double testX = 1.5; testX < 6.0; testX += 1)
        {
            double result = Task3.Lagrange(xValues, yValues, testX);
            Console.WriteLine($"Values at current x = {testX}: y = {result}");
        }
        Console.WriteLine(new string('-', 50));
        double[] xx = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
        double[] yy = { -2, 0.2, 1.8, 4.2, 5.8, 8.2, 10.2, 12.2, 13.8 };

        var (k, b) = Task4.ComputeCoefficients(xx, yy);
        double r2 = Task4.ComputeR2(xx, yy, k, b);

        Task4.PrintSummary(k, b, r2);
        Task4.PrintComparisonTable(xx, yy, k, b);
    }
}