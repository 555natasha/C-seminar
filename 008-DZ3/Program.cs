// Написать программу, которая принимает на вход число и выдаёт, чётное оно или нечётное.
System.Console.WriteLine("Введите число: ");
string str = Console.ReadLine(); // считываем вводимую строку
int num = Convert.ToInt32(str); // строку конвертируем в число

if(num%2 == 0) {Console.WriteLine("Число чётное");}
else {Console.WriteLine("Число нечётное");}