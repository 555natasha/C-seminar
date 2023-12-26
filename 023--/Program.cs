// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int number = GetNumber();

static int GetNumber()
{
    Console.WriteLine("Введите чисо: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int sum = FindSum(number);

int FindSum(int number)
{
    if(number == 0)
    {
        return 0;
    }
    int sum = number%10 + FindSum(number/10);
    return sum;
}
Console.WriteLine(sum);
