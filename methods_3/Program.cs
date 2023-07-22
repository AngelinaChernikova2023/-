// Существует 4 основных типов методов
// 1. Не принимают, не возвращают
// 2. Принимают, не возвращают
// 3. Не принимают, но возвращают
// 4. Принимают и возвращают

// Практика


// вид1
// void Method1()
// {
//     Console.WriteLine("Автор...");
// }
// Method1();

// вид2
// void Method1(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method1("Текст сообщения");


// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//        Console.WriteLine(msg);
//      i++;
//     }

// }
// Method21(msg: "Текст", count: 4);

// вид3
// int Method213()
// {
//     return DateTime.Now.Year;
// }

// int year = Method213();
// Console.WriteLine(year);

// Вид4
// string Method2134(int count, string text)
// {
//     int i = 0;
//     string result = ""; //String.Empty; - пустая строка
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string result = Method2134(10, "123 ");
// Console.WriteLine(result);

// вид4 for
// string Method2134(int count, string text)
// {
//     string result = String.Empty; //String.Empty; - пустая строка
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string result = Method2134(10, "123 ");
// Console.WriteLine(result);

// Цикл в цикле. Вывод таблицы умножения на экран
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

// Работа с текстом.
// Дан текст. В тексте необходимо все пробелы заменить черточками,
// маленькие буквы к заменить большими К,
// а большие С, заменить на маленькие с.

string text = "Я думаю, - сказал князь, улыбаясь, - что"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = qwerty
//            012345
// s[3] // r
string Replace(string text, char oldValue, char newValue)
{
   string result = String.Empty;
   int length = text.Length;
   for (int i = 0; i < length; i++)
   {
    if (text[i] == oldValue) result = result + $"{newValue}";
    else result = result + $"{text[i]}";
   }
   return result;
}
string newText = Replace(text, ' ', '_');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);