// 2. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
//в которой находится эта точка.

Console.Write("Введите координаты точки X и Y через пробел:");
string[] coordinates = Console.ReadLine().Split(' ');
int x = Convert.ToInt32(coordinates[0]);
int y = Convert.ToInt32(coordinates[1]);

if (x == 0 ^ y == 0)
{
   while (x == 0 ^ y == 0)
   {
      System.Console.WriteLine("Точка лежит на оси координат. Введите значения координат, отличных от нуля, снова: "); 
      string[] coordinates2 = Console.ReadLine().Split(' ');
      x = Convert.ToInt32(coordinates2[0]);
      y = Convert.ToInt32(coordinates2[1]);
   }
}

if (x > 0 && y > 0)
    Console.WriteLine("I четверть координат");
else 
    if (x < 0 && y > 0)
    Console.WriteLine("II четверть координат");
else 
    if (x < 0 && y < 0)
    Console.WriteLine("III четверть координат");
else if (x > 0 && y < 0)
    Console.WriteLine("IV четверть координат");