// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число
// в массиве. Программа должна выдать ответ: ДА / НЕТ.

int[] array = new int[10];

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); // строку конвертируем в число
System.Console.WriteLine();

FillArray(array);
PrintArray(array);
// FindNumber(number, array);

if (FindNumber(number, array))
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}
// bool FindNumber(number, array);

static void FillArray(int [] collection) // метод заполнения массива рандомными целыми числами
{
    int length = collection.Length; // возвращает длину массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10); // (1,10) - выбранный интервал
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
}

static bool FindNumber(int num, int[] arr) // меотд поиска вводимого числа в массиве
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (num == arr[i])
        {
            return true;
        }
    }
        return false;

}
