// Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

Console.Write("Задачте количество строк в массиве: ");
int rowCol = int.Parse(Console.ReadLine());

Console.Write("Задачте количество столбцов в массиве: ");
int columnCol = int.Parse(Console.ReadLine());

int[,] mass = FillArray(rowCol, columnCol);
PrintArray(mass);
Console.WriteLine();
ChangeArray(mass);
Console.WriteLine("Новый массив: ");
PrintArray(mass);

int[,] FillArray(int rowsCount, int ColumnsCount)
{
    int[,] array = new int[rowsCount, ColumnsCount];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)   
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1,11);
        }
    }
    return array;
}

void PrintArray(int[,] list)
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

void ChangeArray(int[,] arr)
{
    if (arr.GetLength(0) >= 2)
    {
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            int temp = arr[0, i];
            arr[0, i] = arr[arr.GetLength(0) - 1, i];
            arr[arr.GetLength(0) - 1, i] = temp;
        }
    }
}
