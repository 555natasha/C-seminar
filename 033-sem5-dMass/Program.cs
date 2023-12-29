// Задайте двумерный массив из целых чисел. Сформируйте новый одномерный массив, 
// состоящий из средних арифметических значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1 
// => [3 3 5]

int[,] mass = FillArray(3, 4/*, 0, 99*/); // 0 , 99 - mixValuaNext, maxValuaNext
PrintArray(mass);
Console.WriteLine();
FindSr(mass);

/* 
int[,] massSr = new int [mass.GetLength(0)];
for (int i = 0; i < mass.GetLength(0); i++)
{
    int sum=0;
    for (int j = 0; j < mass.GetLength(1); i++)
    {
        sum += mass[i,j];
    }
    massSr[i] = sum / mass.GetLength(1);
}
System.Console.WriteLine($"[{string.Join(", ", massSr)}]");
*/

int[,] FillArray(int rowsCount, int ColumnsCount/*, int minValuaNext,  int maxValuaNext*/) // метод заполнения массива рандомными целыми числами
{
    int[,] array = new int[rowsCount, ColumnsCount];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)   // 0 – это первое измерение массива, то есть число строк в нём 
    {
        for (int j = 0; j < array.GetLength(1); j++) // 
        {
            array[i, j] = rnd.Next(1,10); // rnd.Next(minValuaNext,maxValuaNext + 1)
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

void FindSr(int[,] arr)
{
    int sum;
    int sr = 0;
    for (int i = 0; i < arr.GetLength(0); i++)    
    {
        sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i,j];
        }
        sr = sum / arr.GetLength(1);
        Console.Write(sr + " ");
    }
}