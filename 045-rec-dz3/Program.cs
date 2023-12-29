// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

System.Console.WriteLine("Введите размер одномерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] mass = FillArray(n);
PrintArray(mass);
GetNegativMass(mass, 0);
Console.WriteLine();

int[] FillArray(int size) // метод заполнения массива рандомными целыми числами
{
    int[] numbers = new int[size];
    for (int i = 0; i < numbers.Length; i++)    
    {
        numbers[i] = new Random().Next(1,100);
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

void GetNegativMass(int[] arr, int step) // метод перестановки элементов массива в обратном порядке
{
    if (step < arr.Length)
        {
            GetNegativMass(arr, step + 1);
            Console.Write(arr[step] + " ");
        }
}
