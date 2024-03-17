using System;
using System.Runtime.InteropServices.Marshalling;
class Program
{
    // 11.Напишите программу вывода всех простых чисел, лежащих в интервале (M, N). 
    // Функция, определяющая, является ли число простым (она нерекурсивная)). 
    // Число A простое, если у него ровно 2 делителя: 1 и само A.
    static void Main()
    {
        Console.WriteLine("Введите интервал (M, N): ");
        int M = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine($"Все простые числа лежащие в интервале {M} и {N}: ");
        for (int i = M; i <= N; i++){
            if (pr(i)){
                Console.Write(i + " ");
            }
        }        
    }
    static bool pr(int num){
        if (num <= 1){
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(num);  i++){ // бирем с кв корня чтобы оптимизировать код, т к если есть до кв корня значит есть и после кв корня
            if (num % i == 0){
                return false; // если число не простое у него есть делитель до его квадратного корня,     
            }
        }
        return true; // если число прошло все проверки даем зеленный свет и оно выведется
    }
}
