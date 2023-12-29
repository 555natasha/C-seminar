// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.

Console.Write("Введите первое число:");
int number1 = GetNumber();
Console.Write("Введите второе число:");
int number2 = GetNumber();
Console.WriteLine("Список натуральных чисел в этом интервале: ");

if (number1 < number2)
{
    listNumber(number1, number2);
}
else
{
    listNumber(number2, number1);
}

int GetNumber()
{
    Console.Write(" ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void listNumber(int num1, int num2)
{
    if (num1 <= num2)
    {
        Console.Write(num1 + " ");
        listNumber(num1 + 1, num2);
    }
}