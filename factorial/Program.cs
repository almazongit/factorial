using System;
class Formulas
{
    public static double factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * factorial(n - 1);
        }
    }
    static void Main(string[] args)
    {

        Console.WriteLine("Введите X = ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите N = ");
        double n = Convert.ToDouble(Console.ReadLine());

        double sum = 0;
        for (int i = 0; i <= n; i++)
        {
            sum += (Math.Pow(x, i)) / factorial(i);
        }
        Console.WriteLine("Ответ = " + sum);
    }
}
