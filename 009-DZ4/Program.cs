// Написать программу, которая принимает на вход число N, 
// а на выходе выдает все чётные числа от 1 до N.
System.Console.WriteLine("Введите число: ");
string str = Console.ReadLine(); // считываем вводимую строку
int N = Convert.ToInt32(str); // строку конвертируем в число
int count = 1;
int ch = 0;
while(count < N) 
{
    ch = count;
    if(ch % 2 == 0)
    {
        Console.Write($" {ch}");
    }
    count++;
}