using System;
class Program
{
    // Написать программу вычисления суммы трех чисел, 
    // используя подпрограмму вычисления суммы двух чисел
    static void Main()
    {
        Console.WriteLine("Введите 3 числа: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine($"Сумма 2 первых чисел {a} + {b} = {sum2(a, b)}");
        Console.WriteLine($"Сумма 3 чисел, используя подпрограмму вычисления суммы двух чисел = {sum2(a, b)}.\nСумма всех чисел = {a} + {b} + {c} или {sum2(a, b)} + {c} = {sum2(a, b) + c}");
    }
    static int sum2 (int a, int b){
        return a + b;
    }
}


