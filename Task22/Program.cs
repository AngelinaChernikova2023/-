// Напишите программу, которая
// принимает на вход число (N)
// и выдает таблицу квадратов чисел
// от 1 до N


// Console.Write(«Таблица квадратов:\n»);
// for (int i = 1; i <= n; i++)
// {
//     int k = i * i;
//     Console.Write($»{ k}, «);
// }
Console.WriteLine("Введите целое число А");
int number = Convert.ToInt32(Console.ReadLine());

TableSquare(number);

void TableSquare(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count} | {count * count}");
        count++;
    }
}
// Другое решение!!!

// for (int i = 1; i <= number; i++)
// {
//     Console.WriteLine($"{i * i} ");
// }

// // Функция ввода сообщения
// int ReadInt(string message)
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }