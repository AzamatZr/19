using System;
using System.Runtime.InteropServices.Marshalling;
class Program
{
    // Даны два натуральных числа. Определить, используя функции, в каком из них:
    // 11.	больше произведение ненулевых цифр.
    static void Main()
    {
        Console.WriteLine("Введите 2 натуральных числа: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        if (a > 0 && b > 0){
            Console.WriteLine($"В каком числе {a} или {b} больше произведение ненулевых цифр?");
            if (sr(a) > sr(b)) Console.WriteLine($"Произведение больше в 1 числе. Оно равно {sr(a)}");
            else if (sr(a) < sr(b)) Console.WriteLine($"Произведение больше во 2 числе. Оно равно {sr(b)}");
            else Console.WriteLine($"Произведения ненулевых цифр в обоих одинаковое. Равно = {sr(a)}");
        }
        else Console.WriteLine("Введите натуральные числа.");
    }
    static int sr(int a){
        int p1 = 1; 
        while (a > 0){
            int x = a % 10;
            if (x != 0) p1 *= x;
            a = a / 10;
        }
        return p1;
    }
}
