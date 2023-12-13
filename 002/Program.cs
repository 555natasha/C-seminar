// напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго

System.Console.WriteLine("Введите первое число: ");
string str1 = Console.ReadLine(); // считываем вводимую строку
int num1 = Convert.ToInt32(str1); // строку конвертируем в число

System.Console.WriteLine("Введите второе число: ");
string str2 = Console.ReadLine(); // считываем вводимую строку
int num2 = Convert.ToInt32(str2); // строку конвертируем в число
int sqr_num2 = num2*num2;
System.Console.WriteLine($" sqr_num2 = {sqr_num2}");

if (num1 == sqr_num2)
{
    //System.Console.WriteLine($" первое число: num1 = {num1}");
    //System.Console.WriteLine($" второе число: num2 = {num2}");
    System.Console.WriteLine("YES");
}
else
{
    System.Console.WriteLine("NO");
}