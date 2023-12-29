// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

Console.Write("Введите целое неотрицательное число m: ");
int m = GetNumber();

Console.Write("Введите целое неотрицательное число n: ");
int n = GetNumber();

int result = Ackermann(m, n);
Console.WriteLine($"Функция Аккермана({m}, {n}) = {result}");

/* --------методы-------- */

int GetNumber()
{
    Console.Write(" ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}