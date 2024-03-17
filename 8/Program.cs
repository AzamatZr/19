using System;
using System.Runtime.InteropServices.Marshalling;
class Program
{
    // Даны два массива целых чисел одинаковой размерности
    // Составить из элементов данных массивов новый (третий) массив по правилу:
    // 11.	каждый элемент нового массива есть отрицательный из двух соответствующих элементов 
    // данных массивов, 0 – в противном случае
    static Random random = new Random();
    static void Main()
    {
        Console.WriteLine("Введите размер массивов: ");
        int n = int.Parse(Console.ReadLine());
        int[] array1 = new int[n];
        int[] array2 = new int[n];
        Console.WriteLine($"Массив 1, размером {n}:");
        inputArray(array1, n, -15, 15);
        Console.WriteLine($"Массив 2, размером {n}:");
        inputArray(array2, n, -15, 15);
        Console.WriteLine($"Массив 3, размером {n}, в котором каждый новый элемент есть отрицательное из двух соответствующих элементов, иначе 0:");
        int[] array3 = new int[n];
        array_3(array1, array2, array3, n);
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
    static void array_3(int[] x, int[] y, int[] z, int n){
        for (int i = 0; i < n; i++){
            if (x[i] < 0 && y[i] < 0){
                if (x[i] < y[i]) z[i] = x[i];
                else z[i] = y[i];
            }
            else if (x[i] < 0 || y[i] < 0){
                if (x[i] < 0) z[i] = x[i];
                else z[i] = y[i];
            }
        }
        for (int i = 0; i < n; i++){
            Console.Write(z[i] + "\t");
        }
        Console.WriteLine();
    }
}   
