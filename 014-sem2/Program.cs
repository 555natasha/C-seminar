// 4. Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.

System.Console.WriteLine("Введите натуральное число: ");
string str = Console.ReadLine(); // считываем вводимую строку
int N = Convert.ToInt32(str); // строку конвертируем в число
if (N <= 0)
{
    System.Console.WriteLine("не является натуральным числом. Повторите ввод: ");
    str = Console.ReadLine(); // считываем вводимую строку
    N = Convert.ToInt32(str); // строку конвертируем в число
}
//if (N < 10)
//{
 //   Console.WriteLine(N);
//}
//else
//{
        int delitel = 1;
        while (N / delitel > 10)
        {
            delitel *= 10;
        }
        while (delitel > 0)
        {
            int cifra = N / delitel;
            Console.Write(cifra);
            N %= delitel;
            delitel /= 10;
            if (delitel > 0)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
//}

        


// static void Main()
 //   {
 //       Console.Write("Enter a natural number: ");
 //       if (int.TryParse(Console.ReadLine(), out int number) && number >= 0)
  //      {
 //           Console.WriteLine("Digits separated by commas: " + GetDigitsSeparatedByCommas(number));
 //       }
 //       else
 //       {
  //          Console.WriteLine("Invalid input. Please enter a non-negative integer.");
 //       }
 //   }

 //   static string GetDigitsSeparatedByCommas(int n)
 //   {
        // Convert the number to a string and split it into an array of characters
 //       char[] digits = n.ToString().ToCharArray();

        // Join the array of characters into a string with commas
 //       return string.Join(", ", digits);
 //   }