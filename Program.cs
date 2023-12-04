/*

 Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Результат: " + GetNumbersDescending(n));
    }

    static string GetNumbersDescending(int number)
    {
        if (number == 1)
        {
            return "1";
        }
        else
        {
            return number + ", " + GetNumbersDescending(number - 1);
        }
    }
}