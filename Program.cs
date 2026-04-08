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
    }
}