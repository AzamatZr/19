using System;
using System.Runtime.InteropServices.Marshalling;
class Program
{
    // Даны два трехзначных числа. Вывести на экран наибольшую из средних цифр этих чисел, 
    // используя подпрограмму поиска средней цифры
    static void Main()
    {
        Console.WriteLine("Введите 2 трехзначных числа: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        if (a >= 100 && b >= 100){
            if (a % 100 / 10 == b % 100 / 10) Console.WriteLine($"Наибольшое среднее число из {a} и {b} = Они равны");
            else Console.WriteLine($"Наибольшое среднее число из {a} и {b} = {sred(a, b)}");
        }
        else Console.WriteLine("Введите трехзначные числа.");
    }
    static int sred(int a, int b){
        if (a % 100 / 10 > b % 100 / 10) return a % 100 / 10;
        else return (b % 100 / 10);
    }
}