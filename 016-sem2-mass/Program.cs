// напишите программу, которая принимает на вход два числа и выводит, 
// является ли второе число кратным первому. Если второе число некратно
// первому, то программа выводит остаток от деления.

System.Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine()); // строку конвертируем в число

System.Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine()); // строку конвертируем в число

int del = num1 % num2;
if (del == 0)
{
    Console.WriteLine($"Первое число {num1} кратно второму числу {num2}");
}
else
{
    Console.WriteLine($"Остаток от деления первого числа на второе равен {del}");
}