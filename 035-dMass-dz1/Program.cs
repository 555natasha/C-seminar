// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Задачте количество строк в массиве: ");
int rowCol = int.Parse(Console.ReadLine());

Console.Write("Задачте количество столбцов в массиве: ");
int columnCol = int.Parse(Console.ReadLine());

int[,] mass = FillArray(rowCol, columnCol);
PrintArray(mass);
Console.WriteLine();

Console.Write("Введите индекс искомого элемета в строке: ");
int rowIndex = int.Parse(Console.ReadLine());

Console.Write("Введите индекс искомого элемента в столбце: ");
int columnIndex = int.Parse(Console.ReadLine());

int result = GetElementValue(mass, rowIndex, columnIndex);

if (result != -1)
{
    Console.WriteLine($"Значение элемента ({rowIndex}, {columnIndex}): {result}");
}
else
{
    Console.WriteLine($"Элемента ({rowIndex}, {columnIndex}) в массиве нет");
}

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

int GetElementValue(int[,] arr, int RowsIndex, int ColumsIndex)
{
    if (RowsIndex >= 0 && RowsIndex < arr.GetLength(0) && ColumsIndex >= 0 && ColumsIndex < arr.GetLength(1))
        {
            return arr[RowsIndex, ColumsIndex];
        }
        else
        {
            return -1;
        }
}