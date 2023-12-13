// Напишите программу, которая принимает на вход трехзначное число 
// и на выходе показывает последнее число этого числа
System.Console.WriteLine("Введите трехзначное число: ");
string str = Console.ReadLine(); // считываем вводимую строку
int NNN = Convert.ToInt32(str); // строку конвертируем в число
if (NNN > 99 && NNN < 1000)
{
    int nnn=NNN%10;
    Console.WriteLine(nnn);
}
else
{
    Console.WriteLine("вы ввели не трехзначное число");
}