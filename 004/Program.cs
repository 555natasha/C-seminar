// напишите программу, которая на вход принимает число N, а на выходе показывает все целые числа от -N до N
System.Console.WriteLine("Введите число N: ");
string str = Console.ReadLine(); // считываем вводимую строку
int N = Convert.ToInt32(str); // строку конвертируем в число
System.Console.WriteLine($" Число N = {N}");
int n = -1*N;
//for(int x >= n; x <= N; x++)
while(n<=N)
{
    Console.WriteLine($" {n}");
    n++;
}