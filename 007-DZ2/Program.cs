// Написать программу, которая на вход принимает 3 числа и на выходе выдает максимальное из них.
System.Console.WriteLine("Введите первое число: ");
string str1 = Console.ReadLine(); // считываем вводимую строку
int num1 = Convert.ToInt32(str1); // строку конвертируем в число
System.Console.WriteLine("Введите второе число: ");
string str2 = Console.ReadLine(); // считываем вводимую строку
int num2 = Convert.ToInt32(str2); // строку конвертируем в число
System.Console.WriteLine("Введите третье число: ");
string str3 = Console.ReadLine(); // считываем вводимую строку
int num3 = Convert.ToInt32(str3); // строку конвертируем в число

int max = num1;
if (max < num2) 
{
    max = num2;
}
if (max < num3) 
{
    max = num3;
}
Console.WriteLine($"max = {max}");