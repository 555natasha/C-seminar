// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
//Пример
//2 3 4 3
//4 3 4 1 => 2 + 3 + 5 = 10
//2 9 5 4

int[,] mass = FillArray(4, 8/*, 0, 99*/); // 0 , 99 - mixValuaNext, maxValuaNext
PrintArray(mass);
Console.WriteLine();
//FindSum(mass);
System.Console.WriteLine($"\nСумма элементов главной диагонали: {FindSum(mass)}");

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

int FindSum(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)    
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j)
            {
                sum = sum + arr[i,j];
                Console.Write(arr[i,j] + " ");
            }
        }
    }
    return sum;
}