// Напишите программу, которая принимает на вход 
// трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number = number * -1;
}
if (number >= 100 && number <=999)
{
int firstDight = number / 10;
int secondDight = firstDight % 10;
Console.WriteLine($"Вторая цифра числа: {secondDight}");
}
else
{
    Console.WriteLine("Ошибка ввода");
}

// {
// int firstDight = number / 100;
// int thirdDight = number % 10;
// int secondDight = firstDight * 10 + thirdDight;
// Console.WriteLine($"Вторая цифра числа: {secondDight}");
// }