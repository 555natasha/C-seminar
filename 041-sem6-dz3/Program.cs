// Задайте произвольную строку. Выясните, является ли она палиндромом.

string str = GetString();
if (IsPolindrom(str))
{
    Console.WriteLine($"Ввведенная сторка  строка - полиндром");
}
else Console.WriteLine($"Ввведенная сторка  строка - НЕ полиндром");


/*------------Методы-------------*/
string GetString()
{
    Console.Write("Введите строку: ");
    string str = Console.ReadLine();
    return str;
}

bool IsVowel(char c)
{
    string vovels = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    return vovels.Contains(c); // если этот элемент есть, то он возвращает тру
}

bool IsPolindrom(string strok)
{
    char[] charArray = strok.ToCharArray();

    for (int i = 0; i < strok.Length /2; i++)
    {
        if (charArray[i] != charArray[strok.Length - 1 - i])
        {
           return false;
        };
    }
    return true;
}


/*
// вариант идеального примера с платормы

public class Task3
{
public static void Main(string[] args)
{
// Входная строка для проверки
string input = "шалаш";
// Вызов метода для проверки, является ли строка палиндромомbool isPalindrome = IsPalindrome(input);
// Вывод результата
Console.WriteLine(isPalindrome ? "Да" : "Нет");
}
// Метод для проверки, является ли строка палиндромомpublic static bool IsPalindrome(string str)
{
// Нормализация строки путем удаления не буквенно-цифровыхсимволов и приведения к нижнему регистру
string normalized = new
string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
// Сравнение строки с ее перевернутым вариантом
return normalized.SequenceEqual(normalized.Reverse());
}
}

*/