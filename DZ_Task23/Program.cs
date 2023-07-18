// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите целое число А");
int number = Convert.ToInt32(Console.ReadLine());

// Console.Write(«Таблица кубов:\n»);
// for (int i = 1; i <= n; i++)
// {
//     int k = i * i * i;
//     Console.Write($»{ k}, «);
// }

for (int i = 1; i <= number; i++)
{
    Console.Write($"{i * i * i} ");
}

// Функция ввода сообщения
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}