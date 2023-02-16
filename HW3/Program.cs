using System.IO;

//Console.Write("Введите строку: ");
//string a = Console.ReadLine() ?? string.Empty;
//string[] b = a.Split('.');
//string? tmp = "";
//for (int i = 0; i < b.Length; i++)
//{
//    if (i == 0)
//    {
//        tmp = b[i].Substring(0, 1);
//        tmp = tmp.ToUpper();
//        b[i] = tmp + b[i].Substring(1, b[i].Length - 1);
//    }
//    else
//    {
//        tmp = b[i].Substring(1, 1);
//        tmp = tmp.ToUpper();
//        b[i] = tmp + b[i].Substring(2, b[i].Length - 2);
//    }
//    Console.WriteLine(tmp);

//}
//for (int i = 0; i < b.Length; i++)
//{
//    if (i == b.Length - 1)
//        Console.Write(b[i]);
//    else Console.Write($"{b[i]}. ");
//}

string text = Console.ReadLine() ?? string.Empty;
string badWord = Console.ReadLine() ?? string.Empty; char[] data = text.ToCharArray();
int pos = 0; while (true)
{
    pos = text.IndexOf(badWord, pos + 1);
    if (pos == -1)
        break;
    for (int i = pos; i < pos + badWord.Length; i++)
        data[i] = '*';
}
Console.WriteLine("\n" + new string(data));
