// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

Console.Write("Задайте количество строк в массиве: ");
int rowCol = int.Parse(Console.ReadLine());

Console.Write("Задайте количество столбцов в массиве: ");
int columnCol = int.Parse(Console.ReadLine());

int[,] mass = FillArray(rowCol, columnCol);
PrintArray(mass);
Console.WriteLine();

Console.Write($"Строка с минимальной суммой элементов - {GetStrokMinSum(mass)}");

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

int GetStrokMinSum(int[,] arr)
{
    int min = 0;
    int count = 0;
    int strokMinSum;
    for (int i = 0; i < arr.GetLength(0); i++)    
    {
        strokMinSum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
          strokMinSum = strokMinSum + arr[i,j];
        }
        if (i == 0)
        {
          min = strokMinSum;  
        }
        if (strokMinSum < min)
        {
            min = strokMinSum;
            count = i;
        }
    }
    return count;
}