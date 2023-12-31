// Задайте двумерный массив символов (тип char[,]). Создать строку из символов этого массива.
// a b c => “abcdef”
// d e f

using System.Text;

char[,] arr = {{'a','b','c'},{'d','e','f'}};
Console.WriteLine("Наш массив:");
PrintCharArray(arr);

Console.Write("\nСтрока: ");
string strok = CreatStrok(arr);
Console.WriteLine(strok);

void PrintCharArray(char[,] list)
{
    for (int i = 0; i < list.GetLength(0); i++)    
    {
        for (int j = 0; j < list.GetLength(1); j++)
        {
            Console.Write(list[i, j] + " "); // Интерполяция строк
        }
        Console.WriteLine();
    }
}

string CreatStrok(char[,] mass)
{
    StringBuilder strB = new StringBuilder();
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            strB.Append(mass[i,j]);
           // st += mass[i,j];
        }
    }
    string str = strB.ToString();
    return str;
}
