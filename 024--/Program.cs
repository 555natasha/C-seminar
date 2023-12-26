// Считать строку с консоли, содержащую латинские буквы. 
// Вывести на экран согласные буквы этой строки.

string stroka = GetString();
PrintString(stroka);

string GetString()
{
    Console.WriteLine("Введите строку: ");
    string list = Console.ReadLine();
    return list;
}

bool IsVowel(char c)
    {
        return c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U';
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }

void PrintString(string str, int index = 0)
{
    if (index < str.Length)
    {
        char c = Char.ToUpper(str[index]);
        if((c >= 'A' && c<= 'Z') && !IsVowel(c)) // ! - превращает истину в лож, а лож - в истину
        {
            Console.Write(c+ " ");
        }
    PrintString(str, index + 1);
    }
}