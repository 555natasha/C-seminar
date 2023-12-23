// Дано натуральное число в диапазоне от 1 до 100000. 
// Создайте массив, состоящий из цифр этого числа. 
// Старший разряд числа долден располагаться на 0-м индексе, младший - на последнем. 
// Размер массива должен быть равен количеству цифр.

// Генерация случайного натурального числа от 1 до 100000
int randomNumber = new Random().Next(1,100001);
Console.WriteLine($"Сгенерированное число: {randomNumber}");
// Вывод массива в одну строку через пробел
Console.Write("Массив из цифр числа: ");

int[] array = GetArray(randomNumber);
PrintArray(array);

// Преобразование числа в строку и определение длины строки (количество цифр)
static int CountDigits(int number) 
{
    string numberString = number.ToString();
    int digitCount = numberString.Length;
    return digitCount;
}

// Заполнение массива цирами числа
static int[] GetArray(int number)
{
    // Определение количества цифр в числе
    int Count = CountDigits(number);
    // Создание массива из цифр числа
    int[] array = new int[Count];
    for (int i = Count - 1; i >= 0; i--)
    {
        array[i] = number % 10;
        number /= 10;
    }
    return array;
}

// Вывод массива через foreach
static void PrintArray(int[] array)
{
    foreach (int digit in array) // Для каждого элемента массива выполняется блок кода внутри цикла
    {
        Console.Write($"{digit} "); // печатаем каждую цифру массива
    }
    Console.WriteLine();
}

// вывод массива, как на лекции, тоже рабочий вариант
//static void PrintArray(int[] col) // метод вывода массива на экран
//{
 //   int count = col.Length; // возвращает длину массива
 //   int position = 0;
 //   while (position < count)
 //   {
 //       Console.Write(col[position] + " ");
 //       position++;
 //   }
//    Console.WriteLine();
//}