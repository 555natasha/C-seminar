// Задать одномерный массив. Заполнить случайными числами. 
// Определите количество простых чисел в этом массиве.

System.Console.WriteLine("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine()); // строку конвертируем в число

int[] mass = new int[N];

FillArray(mass);
PrintArray(mass);
// IsPrime(mass) - не нужно, так как вызывается внутри GetCountPrimeNumber(mass);
// GetCountPrimeNumber(mass);
Console.WriteLine($"\nКоличество простых чисел в массиве равно {GetCountPrimeNumber(mass)}");

// заполняет рандомными числами - работает, но применим к массиву большой размерности
/*
void FillArray(int [] collection) // метод заполнения массива рандомными целыми числами
{
    int length = collection.Length; // возвращает длину массива
    int index = 0;
    Random random = new Random();
    while (index < length)
    {
        collection[index] = random.Next(); 
        index++;
    }
} 
*/

void FillArray(int [] collection) // метод заполнения массива рандомными целыми числами
{
    int length = collection.Length; // возвращает длину массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,100); // (1,100) - выбранный интервал значений массива
        index++;
    }
}

void PrintArray(int[] col) // метод вывода массива на экран
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

bool IsPrime(int num) // метод определения простое число или нет
{
    for(int i = 2; i < num; i++) // i = 2, так как на 0 елить нельзя, а простое число всегда делится на 1
    {
        if(num % i == 0 && i != num)
        {
         return false;
        }
    }
    return true;
}

int GetCountPrimeNumber(int[] list) // возвращает количество простых чисел
{
    int count = 0;
    for(int i = 0; i < list.Length; i++)
    {
        if(IsPrime(list[i]))
        {
            count++;
            Console.Write(list[i] + " ");
        }
    }
    return count;
}