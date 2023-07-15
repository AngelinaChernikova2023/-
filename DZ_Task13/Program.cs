// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите любое многозначное число: ");
int number = int.Parse(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
if (number >= 100 && number <= 999)
{
    int thirdNumber = number % 10;
    Console.WriteLine($"Третья цифра числа: {thirdNumber}");
}
if (number >= 100)
{
    int result = -1;
    {
    while (number > 999)
    {
       number = number / 10;
    }  
    result = number % 10;
    }
    Console.WriteLine($"Третья цифра числа: {result}");
    return;
}

// {
//     int result = -1;
//     if (number >= 100)
//     {
//     while (number > 999)
//     {
//        number = number / 10;
//     }  
//     result = number % 10;
//     }
//     Console.WriteLine($"Третья цифра числа: {result}");
//     return;
// }


