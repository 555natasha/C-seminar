// Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от 1 до N.

int N = GetNumber();
listNumber(N);

int GetNumber()
{
    Console.WriteLine("Введите число N: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void listNumber(int num, int start = 1)
{
    if(start <= N)
    {
        Console.WriteLine(start);
        listNumber(num, start+1);
    }
}





  