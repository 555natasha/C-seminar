// Написать программу, которая принимает на вход 2 числа и выдаёт, 
// какое число большее, а какое - меньшее
System.Console.WriteLine("Введите первое число: ");
string str1 = Console.ReadLine(); // считываем вводимую строку
int num1 = Convert.ToInt32(str1); // строку конвертируем в число
System.Console.WriteLine("Введите второе число: ");
string str2 = Console.ReadLine(); // считываем вводимую строку
int num2 = Convert.ToInt32(str2); // строку конвертируем в число

if (num1 < num2)
{
    Console.WriteLine($" Число num1 {num1} - минимальное");
    Console.WriteLine($" Число num2 {num2} - максимальное");
}
else
{
    Console.WriteLine($" Число num2 {num2} - минимальное");
    Console.WriteLine($" Число num1 {num1} - максимальное");    
}