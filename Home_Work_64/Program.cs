/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */
Console.Clear();

int num, zero;

Console.WriteLine("Данная программа выведет все натуральные числа в промежутке от N до 1.");
Console.Write("Введите число N: ");
num = int.Parse(Console.ReadLine());
zero = 1;

Console.Write("N = {0} -> ", num);
int number = Natural(num, zero);

int Natural(int Counter, int CountingDown)
{
    
    if (Counter > 0)
    {
        Natural(Counter - 1, CountingDown + 1);
        Console.Write($"{CountingDown} ");
    }

    return CountingDown;
}

