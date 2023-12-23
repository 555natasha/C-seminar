// Задайте массив из 10 целых чисел. 
// Напишите программу, которая определяет количество четных чисел в массиве.

int[] array = new int[10];
int chet = 0;

FillArray(array);
PrintArray(array);
chet = FindNumber(chet, array);
System.Console.WriteLine($"Количество четных элементов массива: {chet}");

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

// метод нахождения количества четных элеметов в массиве
static int FindNumber(int res, int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            System.Console.Write(arr[i] + " ");
            res++;
        }
    }
    Console.WriteLine();
    return res;
}