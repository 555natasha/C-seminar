// 3. Напишите программу, которая принимает на вход целое число 
// из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.Write("Введите целое число из отрезка [10, 99]: ");
int number = Convert.ToInt32(Console.ReadLine());
int first = number / 10;
int second = number % 10;
int max = first;
if (max < second) max = second;
// int max = first > second ? first : second;
Console.WriteLine(max);