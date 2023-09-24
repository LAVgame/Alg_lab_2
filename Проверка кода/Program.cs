
using System;
using System.Diagnostics;

class HelloWorld
{
    static void Main()
    {
        var sw = Stopwatch.StartNew();
        sw.Start();
        Console.Write("Введите первое число: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int num2 = int.Parse(Console.ReadLine());

        int gcd = FindGCD(num1, num2);
        Console.WriteLine($"Наибольший общий делитель чисел {num1} и {num2} равен {gcd}");
        sw.Stop();
        Console.WriteLine($"Время выполнения: {sw.Elapsed}"); // Здесь логируем

    }

    static int FindGCD(int a, int b)
    {
        while (b != 0)
        {
            int remainder = a % b;
            a = b;
            b = remainder;
        }
        return a;
    }
}
