using System;
using System.Runtime.InteropServices.Marshalling;
class Program
{
    // Используя функцию (а – обычную, б – рекурсивную) вычисления факториала натурального числа n, найти.
    // 11.	3! + 4! + 5!
    //  3 * 2 * 1
    static void Main()
    {
        Console.WriteLine($"Факториал чисел:\n3 = {A(3)}\n4 = {A(4)}\n5 = {A(5)}");
        Console.WriteLine($"Факторила чисел 3! + 4! + 5!, функцией обычным способом = {A(3) + A(4) + A(5)}");
        Console.WriteLine($"Факторила чисел 3! + 4! + 5!, функцией рекурсивным способом = {B(3) + B(4) + B(5)}");
    }
    static int A(int a){
        int b = 1;
        for (int i = 1; i <= a; i++){
            b *= i;
        }
        return b;
    }
    static int B(int a){
        if (a == 0) return 1;  // терминальная 
        else return B(a - 1) * a;   // рекурсивная 
        // B(3) : B(2) * 3        = 2 * 3 = 6
        // B(2) : B(1) * 2        = 1 * 2 = 2
        // B(1) : B(0) * 1        = 1 * 1 = 1
        // B(0) : 1               
    }
}    
