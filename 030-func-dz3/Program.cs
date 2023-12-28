// Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, 
// второй – предпоследним и т.д.)

System.Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine()); // строку конвертируем в число

int[] mass = FillArray(n);

PrintArray(mass);
GetChangeNumber(mass);
PrintArray(mass);
//Console.WriteLine($"\n{GetChangeNumber(mass)}");

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

void GetChangeNumber(int[] array) // инверсия массива
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}