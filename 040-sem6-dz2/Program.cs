// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные. 
// “aBcD1ef!-” => “abcd1ef!-”

string str = GetString();
string result = str.ToLower();
Console.WriteLine($"Понижен регистр: {result}");

/*------------Методы-------------*/
string GetString()
{
    Console.Write("Введите строку: ");
    string str = Console.ReadLine();
    return str;
}

bool IsVowel(char c)
{
    string vovels = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!-., ?:;";
    return vovels.Contains(c); // если этот элемент есть, то он возвращает тру
}