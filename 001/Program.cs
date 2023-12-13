// Напишите программу, которая вход принимает число и выдает его квадрат (число, умноженное само на себя)
// Например, 4 - 16; -3 - 9; -7 - 49

System.Console.WriteLine("Введите число: ");
string str = Console.ReadLine(); // считываем вводимую строку
int num = Convert.ToInt32(str); // строку конвертируем в число
int sqr = num*num;
//Console.WriteLine("Квадрат числа равен ");
//Console.WriteLine(sqr);
System.Console.WriteLine($" sqr = {sqr}");