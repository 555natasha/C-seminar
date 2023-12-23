// Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20, 90].

int[] array = new int[10];
int result = 0;

FillArray(array);
PrintArray(array);
result = FindNumber(result, array);
System.Console.WriteLine($"Количество элементов >= 20, но <= 90: {result}");

static void FillArray(int [] collection) // метод заполнения массива рандомными целыми числами
{
    int length = collection.Length; // возвращает длину массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,100); // (1,10) - выбранный интервал
        index++;
    }
}

static void PrintArray(int[] col) // метод вывода массива на экран
{
    int count = col.Length; // возвращает длину массива
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
    Console.WriteLine();
}

// метод нахождения элеметов в массиве в интервале [20, 90] и подсчет их количества
static int FindNumber(int res, int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 20 && arr[i] <= 90)
        {
            System.Console.Write(arr[i] + " ");
            res++;
        }
    }
    Console.WriteLine();
    return res;
}