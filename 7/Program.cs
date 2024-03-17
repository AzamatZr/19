using System;
using System.Runtime.InteropServices.Marshalling;
class Program
{
    // Даны два массива a и b целых чисел из диапазона [-15;15].
    // 11.	среднее арифметическое положительных элементов для каждого из массивов.
    static Random random = new Random();
    static void Main()
    {
        Console.WriteLine("Введите размер 1 массива: ");
        int n1 = int.Parse(Console.ReadLine());
        int[] array1 = new int[n1];
        Console.WriteLine("Введите размер 2 массива: ");
        int n2 = int.Parse(Console.ReadLine());
        int[] array2 = new int[n2];
        Console.WriteLine($"Массив 1, размером {n1}:");
        inputArray(array1, n1, -15, 15);
        Console.WriteLine($"Массив 2, размером {n2}:");
        inputArray(array2, n2, -15, 15);
        Console.WriteLine($"Среднее арифмитическое положительных элементов Массива 1, размером {n1}. = {sr(array1, n1)}");
        Console.WriteLine($"Среднее арифмитическое положительных элементов Массива 2, размером {n2}. = {sr(array2, n2)}");
    }
    static void inputArray(int[] array, int n, int a, int b){
    for (int i = 0; i < n; i++){
        array[i] = random.Next(a, b + 1);
    }
    for (int i = 0; i < n; i++){
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
    }
    static double sr(int[] array, int n){
        double s = 0;
        double k = 0;
        double ssr = 0;
        for (int i = 0; i < n; i++){
            if (array[i] > 0){
                s += array[i];
                k++;
            }
        }
        if (k > 0) ssr = s / k;
        return ssr;
    }
}   
