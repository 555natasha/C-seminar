// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

System.Console.WriteLine("Введите число: ");
string str = Console.ReadLine(); // считываем вводимую строку
int num = Convert.ToInt32(str); // строку конвертируем в число

if(num % 7 == 0 && num % 23 == 0) {Console.WriteLine("Число, которое делится на 7 и 23");}
else {Console.WriteLine("Число не подходит");}