using System;
using System.Runtime.InteropServices.Marshalling;
class Program
{
    // Даны 4 отрезка a, b, c, d. Найти площади треугольников (возможных), построенных из этих отрезков.
    static void Main()
    {
        Console.WriteLine("Введите 4 отрезка a, b, c, d: ");
        double a, b, c, d;
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        c = double.Parse(Console.ReadLine());
        d = double.Parse(Console.ReadLine());
        if (test(a, b, c)) geron(a, b, c);
        if (test(a, b, d)) geron(a, b, d);
        if (test(b, c, d)) geron(b, c, d);
        if (test(a, c, d)) geron(a, c, d);
    }
    static bool test(double x, double y, double z){
        if ((x + y > z) && (x + z > y) && (y + z > x) && (x > 0) && (y > 0) && (z > 0)) return true;
        else return false;
    } 
    static void geron(double x, double y, double z){
        // double p = ((x + y + z) / 2);
        Console.WriteLine($"Площадь треугольника со сторанами {x}, {y}, {z} = {Math.Sqrt(((x + y + z) / 2) * (((x + y + z) / 2) - x) * (((x + y + z) / 2) - y) * (((x + y + z) / 2) - z))}");
        // return;
    }
}   