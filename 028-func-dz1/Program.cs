// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, 
// сумма цифр которого чётная.

System.Console.WriteLine("Введите число: ");
while (true)
{
    string str = Console.ReadLine();
    int digitCountStr = str.Length;

    if (str == "q")
    {
        Console.WriteLine("STOP");
        break;
    }
    else
    {
        int numbers = Convert.ToInt32(str); // строку конвертируем в число
        int result = 0;
        for (int i = 0; i < digitCountStr; i++)
        {
            result += numbers % 10;
            numbers /= 10;
        }
        //Console.WriteLine(result);
        if (result % 2 == 0)
        {
            Console.WriteLine("STOP");
            break;
        }
    }
}
