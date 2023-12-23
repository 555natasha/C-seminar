// Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементами массива.

double[] array = new double[10];

FillArray(array);
Console.WriteLine("Сгенерированный массив:");
PrintArray(array);
double difference = FindDifference(array);

Console.WriteLine($"\nРазница между минимальным и максимальным элементами: {difference}");


static void FillArray(double [] collection) // метод заполнения массива рандомными целыми числами
{
    int length = collection.Length; // возвращает длину массива
    int index = 0;
    Random random = new Random();
    while (index < length)
    {
        collection[index] = Math.Round(random.NextDouble() * 10, 1); 
        index++;
    }
}

static void PrintArray(double[] col) // метод вывода массива на экран
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

static double FindDifference(double[] array)
    {
        if (array.Length == 0)
        {
            Console.WriteLine("Массив не может быть пустым");
            return 0;
            //throw new ArgumentException("Array cannot be empty.");
        }
        double min = array[0];
        double max = array[0];

        // Найдем максимум и минимум
        foreach (double number in array)
        {
            if (number < min)
            {
                min = number;
            }

            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"Максимальный элемент: {max} \nМинимальный элемент: {min}");
        // Ищем разницу
        double difference = max - min;
        return difference;
    }