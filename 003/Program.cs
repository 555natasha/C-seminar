// Напишите программу, в которой мы задаем число и она возвращает нам день недели
// например, 3 - среда, 5 - пятница
System.Console.WriteLine("Введите число: ");
string str = Console.ReadLine(); // считываем вводимую строку
int num_day = Convert.ToInt32(str); // строку конвертируем в число
//int sqr = num*num;
if(num_day > 0 && num_day <= 7)
{
    if (num_day==1) Console.WriteLine("Сегодня - понедельник");
    if (num_day==2) Console.WriteLine("Сегодня - вторник");
    if (num_day==3) Console.WriteLine("Сегодня - среда");
    if (num_day==3) Console.WriteLine("Сегодня - четверг");
    if (num_day==5) Console.WriteLine("Сегодня - пятница");
    if (num_day==6) Console.WriteLine("Сегодня - суббота");
    if (num_day==7) Console.WriteLine("Сегодня - воскресение");
}
else
{
    Console.WriteLine("Такого дня недели нет");
}