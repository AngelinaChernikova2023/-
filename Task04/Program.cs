// // Напишите программу, которая принимает на вход
// трехзначное число и на выходе показывает
// последнюю цифру этого числа

Console.WriteLine("ВВедите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0)
{
    num = num * -1;
}
if(num >= 100 && num <=999)
{
    int lastDigit = num % 10;
    Console.WriteLine($"Последняя цифра числа: {lastDigit}");
}
else
{
    Console.WriteLine("Ошибка ввода");
}
