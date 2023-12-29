// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении которых 
// расположен наименьший элемент массива. Под удалением понимается создание нового 
// двумерного массива без строки и столбца

Console.Write("Задайте количество строк в массиве: ");
int rowCol = int.Parse(Console.ReadLine());

Console.Write("Задайте количество столбцов в массиве: ");
int columnCol = int.Parse(Console.ReadLine());

int[,] mass = FillArray(rowCol, columnCol);
PrintArray(mass);
int[,] newArray = DeleteRowAndColumnWithSmallestElement(mass);
Console.WriteLine("\nМассив после удаления строки и столбца на минимальном элементе:");
PrintArray(newArray);

/* -------------- методы --------------*/
int[,] FillArray(int rowsCount, int columnsCount)
{
    int[,] array = new int[rowsCount, columnsCount];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 11);
        }
    }
    return array;
}

void PrintArray(int[,] list)
{
    for (int i = 0; i < list.GetLength(0); i++)    
    {
        for (int j = 0; j < list.GetLength(1); j++)
        {
            Console.Write(list[i, j] + " "); // Интерполяция строк
        }
        Console.WriteLine();
    }
}

int[,] DeleteRowAndColumnWithSmallestElement(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);
        int minElement = array[0,0];
        int minRow = 0;
        int minColumn = 0;

        // Нахождение позиции минимального элемента массива
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (array[i, j] < minElement)
                {
                    minElement = array[i, j];
                    minRow = i;
                    minColumn = j;
                }
            }
        }

        // Создание нового массива под заполнение
        int[,] newArray = new int[rows - 1, columns - 1];

        // Копирование элементов в новый массив, исключая строку и столбец
        int newRow = 0;
        for (int i = 0; i < rows; i++)
        {
            if (i != minRow)
            {
                int newColumn = 0;  // Reset newColumn for each new row
                for (int j = 0; j < columns; j++)
                {
                    if (j != minColumn)
                    {
                        newArray[newRow, newColumn] = array[i, j];
                        newColumn++;
                    }
                }
                newRow++;
            }
        }
        return newArray;
    }


    
        /*
        for (int i = 0, newRow = 0; i < rows; i++)
        {
            if (i == minRow)
                continue;
                // механизм пропуска - используется для исключения строки и столбца, содержащих 
                // наименьший элемент, при копировании элементов из исходного массива в новый массив 
                // во время создания обновленного массива. 
                // В результате получается новый массив с уменьшенными размерами, 
                // исключающий строку и столбец наименьшего элемента.
            for (int j = 0, newColumn = 0; j < columns; j++)
            {
                if (j == minColumn) 
                    continue;
                newArray[newRow, newColumn] = array[i, j];
                newColumn++;
            }
            newRow++;
        } */