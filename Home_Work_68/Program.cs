/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */
Console.Clear();

int n, m;

Console.WriteLine("Программа вычисления функции Аккермана");
Console.Write("Введите число m = ");
m = int.Parse(Console.ReadLine());

Console.Write("Введите число n = ");
n = int.Parse(Console.ReadLine());

int accerman = Accerman(m, n);
Console.WriteLine("m = {0}, n = {1} -> Accerman({0}, {1}) = {2}", m, n, accerman);

/* int inverse = inverseAccerman(n);
Console.WriteLine(inverse); */

int Accerman(int M, int N)
{
     if (M == 0)
    {
        return N + 1;
    }
    else if (M > 0 && N == 0)
    {
        return Accerman(M - 1, 1);
    }
    else if (M > 0 && N > 0)
    {
        return Accerman(M - 1, Accerman(M, N - 1));
    }
    else
    {
        return N + 1;
    } 

}

/* int inverseAccerman(int K)
{
    if (K <= 4)
    {
        return K;
    }
    int a = inverseAccerman(K - 1);
    int d = inverseAccerman(K - 2);
    return a + d;
} */


