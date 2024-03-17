using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices.Marshalling;
class Program
{
    // Составить рекурсивную функцию вычисления n-го члена арифметической прогрессии. 
    // Найти с ее помощью:  7-й член прогрессии, 11-й член прогрессии, 
    // первое число этой последовательности, большее заданного числа M.
    // 11.	3,8,13,18,23,
    // a.n = a.1 + d * (n - 1)
    // d = 5 
    // a.n+1 = a.n + d
    static void Main()
    {
        int a1 = 3;
        int d = 5;
        Console.WriteLine($"7 член арифметической прогрессии = {arf(7, a1, d)}"); // 33
        Console.WriteLine($"11 член арифметической прогрессии = {arf(11, a1, d)}"); // 53
        Console.WriteLine("Введите число M: ");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine($"Первое число последевательности болеше заданного числа {m}: {find(m, a1, d)}");
    }
    static int arf(int n, int a1, int d){
        if (n == 1)
            return a1;
        else     
            return arf(n - 1, a1, d) + d; // находим предыдущий член прогресси и к ниму прибавляем разность, 
            // чтобы получить следующий член прогрессии, так происходит пока не дойдем до 1, потом возвращется 1 член и суммируется со остальными
            // n = 3
            // 3 не равно 1 значит вызывем уже 2
            // 2 не равно 1 значит вызваем уже 1
            // 1 равно 1 возвращаем первый член = 3 
            //  3 + 5 = 8
            //  8 + 5 = 13 это и есть 3 член
    }
    static int find(int m, int a1, int d){
        int n = 1; // 
        while(true){
            int result = a1 + d * (n - 1);
            if (result > m) // находим член прогресси начиная с 1 и сравниваем с числом М, если больше сразу возвращаем
                return result;
            n++;
        }
    }
}    
