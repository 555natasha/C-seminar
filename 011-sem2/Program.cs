// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
//в которой находится эта точка.

Console.WriteLine("Задайте координаты точки такие, чтобы x ≠ 0 и Y ≠ 0");
System.Console.WriteLine("Введите Х: ");
string strX = Console.ReadLine(); // считываем вводимую строку
int X = Convert.ToInt32(strX); // строку конвертируем в число
if (X == 0)
{
   System.Console.WriteLine("X не должен быть равен 0. Введите значение снова: "); 
   strX = Console.ReadLine(); // считываем вводимую строку
   X = Convert.ToInt32(strX); // строку конвертируем в число
}

System.Console.WriteLine("Введите Y: ");
string strY = Console.ReadLine(); // считываем вводимую строку
int Y = Convert.ToInt32(strY); // строку конвертируем в число
if (Y == 0)
{
   System.Console.WriteLine("Y не должен быть равен 0. Введите значение снова: "); 
   strY = Console.ReadLine(); // считываем вводимую строку
   Y = Convert.ToInt32(strY); // строку конвертируем в число
}

if(X<0 && Y<0) 
{
    Console.WriteLine("номер координатной четверти - III");
}
if(X<0 && Y>0) 
{
    Console.WriteLine("номер координатной четверти - II");
}
if(X>0 && Y<0) 
{
    Console.WriteLine("номер координатной четверти - IV");
}
if(X>0 && Y>0) 
{
    Console.WriteLine("номер координатной четверти - I");
}