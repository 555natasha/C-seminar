// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.

// Пример
// 2 3 4 3     4 3 4 3
// 4 3 4 1 =>  4 3 4 1
// 2 9 5 4     2 9 25 4

int[,] mass = FillArray(4, 8/*, 0, 99*/); // 0 , 99 - mixValuaNext, maxValuaNext
PrintArray(mass);
Console.WriteLine();
FindIndex(mass);
PrintArray(mass);

int[,] FillArray(int rowsCount, int ColumnsCount/*, int minValuaNext,  int maxValuaNext*/) // метод заполнения массива рандомными целыми числами
{
    int[,] array = new int[rowsCount, ColumnsCount];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)   // 0 – это первое измерение массива, то есть число строк в нём 
    {
        for (int j = 0; j < array.GetLength(1); j++) // 
        {
            array[i, j] = rnd.Next(1,11); // rnd.Next(minValuaNext,maxValuaNext + 1)
            //numbers[i] = new Random().Next(100,1000);
        }
    }
    return array;
}

void PrintArray(int[,] list) // метод заполнения массива рандомными целыми числами
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

void FindIndex(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)    
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                arr[i,j] = arr[i,j] * arr[i,j];
            }
        }
    }
}
