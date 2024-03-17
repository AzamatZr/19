using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices.Marshalling;
class Program
{
    // Написать рекурсивную функцию вычисления чисел Фибоначчи: 1,1,2,3,5,8,13,21,… Используя ее, найти
    // 11.	сумму первых семи четных членов последовательности

    static void Main()
    {
        int count = 0;
        int i = 3;
        int s = 0;
        while (count < 7){ 
            if (fib(i) % 2 == 0){
                s = s + fib(i);
                count++;
            }
            i++;
        }
        Console.WriteLine($"Сумма первых семи четных членов последовательности = {s}");
    }
    static int fib(int nomer){
        if (nomer == 1 || nomer == 2) 
            return 1;
        else 
            return fib(nomer - 1) + fib(nomer - 2);
    }
}    
