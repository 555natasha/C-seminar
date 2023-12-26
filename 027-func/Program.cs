// Задайте массив из n случайных чисел. 
// Найдите количество чисел, которые заканчиваются на 1 и делятся нацело на 7.

System.Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine()); // строку конвертируем в число

int[] mass = FillArray(n);

PrintArray(mass);
Console.WriteLine($"\nКоличество искомых чисел равно {FindColNumber(mass)}");

//Console.WriteLine($"\nКоличество простых чисел в массиве равно {GetCountPrimeNumber(mass)}");

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

// семинарский метод заполнения массива
int[] FillArray(int size) // метод заполнения массива рандомными целыми числами
{
    int[] numbers = new int[size];
    for (int i = 0; i < numbers.Length; i++)    
    {
        numbers[i] = new Random().Next(1,100);
    }
    return numbers;
}

/* это лекционный рабочий метод
void FillArray(int [] collection) // метод заполнения массива рандомными целыми числами
{
    int length = collection.Length; // возвращает длину массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,100); // (1,100) - выбранный интервал значений массива
        index++;
    }
}*/

// тоже переписали метод
void PrintArray(int[] col) // метод вывода массива на экран
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write(col[i] + " ");
    }
    Console.WriteLine();
}

// рабочий метод (ниже метод проще написанный)
/*
bool IsPrime(int num) // метод определения простое число или нет
{
    for(int i = 0; i < num; i++)
    {
        if(num % 10 == 1 && num % 7 == 0)
        {
         return true;
        }
    }
    return false;
} */

bool IsPrime(int num) // метод определения простое число или нет
{
    return (num % 10 == 1 && num % 7 == 0);
}

// () & () - выполнит сначала все действия в двух скобках, а затем их сравнит - битовый ампликат
// () && () - проверит первую скобку, если условие не подойдет, то во вторую даже не пойдет - логический оперант

int FindColNumber(int[] mass)
{
    int count = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if(IsPrime(mass[i]))
        {
            count++;
            Console.Write(mass[i] + " ");
        }
    }
    return count;
}