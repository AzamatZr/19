using System;
using System.Runtime.InteropServices.Marshalling;
class Program
{
    // 11.	Даны катеты двух прямоугольных треугольников.
    // Найти радиусы описанных около них окружностей
    // 3 4 = 5,  R = 2,5
    // 5 12 = 13
    // 7 24 = 25
    // 8 15  = 17
    static void Main()
    { 
        Console.WriteLine("Введите катеты 1 треугольника: ");
        double kat1_1 = double.Parse(Console.ReadLine());
        double kat1_2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите катеты 2 треугольника: ");
        double kat2_1 = double.Parse(Console.ReadLine());
        double kat2_2 = double.Parse(Console.ReadLine());
        if (kat1_1 < Math.Sqrt(Math.Pow(kat1_1, 2) + Math.Pow(kat1_2, 2)) && kat1_2 < Math.Sqrt(Math.Pow(kat1_1, 2) + Math.Pow(kat1_2, 2)) && kat2_1 < Math.Sqrt(Math.Pow(kat2_1, 2) + Math.Pow(kat2_2, 2)) && kat2_2 < Math.Sqrt(Math.Pow(kat2_1, 2) + Math.Pow(kat2_2, 2))){
            Console.WriteLine($"Радиус 1 окружности описанной возле треугольника = {Triangle(kat1_1, kat1_2)}");
            Console.WriteLine($"Радиус 2 окружности описанной возле треугольника = {Triangle(kat2_1, kat2_2)}");
        }
        else Console.WriteLine("Введите другие значения катетов.");
        
    }
    static double Triangle(double kat1, double kat2){
        return 0.5 * Math.Sqrt(kat1 * kat1 + kat2 * kat2);
    }
}