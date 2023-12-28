// Задайте массив, заполненный случайными трехзначными числами. 
// Напишите программу, которая выдает количество четных чисел в массиве.

System.Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine()); // строку конвертируем в число

int[] mass = FillArray(n);

PrintArray(mass);
Console.WriteLine($"\nКоличество четных элементов массива равно {FindEvenNumber(mass)}");

int[] FillArray(int size) // метод заполнения массива рандомными целыми числами
{
    int[] numbers = new int[size];
    for (int i = 0; i < numbers.Length; i++)    
    {
        numbers[i] = new Random().Next(100,1000);
    }
    return numbers;
}

void PrintArray(int[] col) // метод вывода массива на экран
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write(col[i] + " ");
    }
    Console.WriteLine();
}

int FindEvenNumber(int[] array) // определение четности элементов и подсчет их
{
   // int countEven = 0;
    int EvenCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            EvenCount++;
            Console.Write(array[i] + " ");
           // countEven += 1;
        }
    }
    return count;
}