using System;
using System.Runtime.InteropServices.Marshalling;
class Program
{
    // Даны два предложения. Найти, используя подпрограмму:
    // 11.	общее количество гласных букв в них.
    static void Main()
    {
        Console.WriteLine("Введите 1 предложение: ");
        string s1 = Console.ReadLine();
        string s1_L = s1.ToLower();
        Console.WriteLine("Введите 2 предложение: ");
        string s2 = Console.ReadLine();
        string s2_L = s2.ToLower();
        Console.WriteLine($"Общее количесвто гласных букв в двух предложениях = {count(s1_L) + count(s2_L)}\nКоличество гласных букв в 1 предложение {count(s1_L)}.\nКоличество гласных букв во 2 предложение {count(s2_L)}");
    }
    static int count(string s){
        int k = 0;
        int n = s.Length;
        for (int i = 0; i < n; i++)
            if (s[i] == 'а' || s[i] == 'о' || s[i] == 'э' || s[i] == 'ы' || s[i] == 'я' || s[i] == 'ё' || s[i] == 'е' || s[i] == 'ю' || s[i] == 'и') k++;
                // || s[i] == 'А' || s[i] == 'О' || s[i] == 'Э' || s[i] == 'Ы' || s[i] == 'Я' || s[i] == 'Ё' || s[i] == 'Е' || s[i] == 'Ю' || s[i] == 'И' ) k++;
        return k;
    }
}   
