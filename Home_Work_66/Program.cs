/* Задача 66: Задайте значения M и N.
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
 */
Console.Clear();

int min, max, cons;

Console.WriteLine("Программа находит сумму натуральных элементов в промежутке от min до max.");
Console.Write("Введите число min = ");
min = int.Parse(Console.ReadLine());
cons = min;

Console.Write("Введите число max = ");
max = int.Parse(Console.ReadLine());


int num = Summ(min, max, cons);

int Summ(int M, int N, int Const)
{
    int num = Const;
    if (N > num)
    {
        Summ(M + N, N - 1, Const);
    }
    else if (N == num)
    {
        Console.WriteLine(M);
    }
    return M;
}