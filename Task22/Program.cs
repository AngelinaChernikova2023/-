// Напишите программу, которая
// принимает на вход число (N)
// и выдает таблицу квадратов чисел
// от 1 до N

Console.WriteLine("Введите целое число А");
int number = Convert.ToInt32(Console.ReadLine());

// Console.Write(«Таблица квадратов:\n»);
// for (int i = 1; i <= n; i++)
// {
//     int k = i * i;
//     Console.Write($»{ k}, «);
// }

for (int i = 1; i <= number; i++)
{
    Console.WriteLine($"{i * i} ");
}

// Функция ввода сообщения
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}