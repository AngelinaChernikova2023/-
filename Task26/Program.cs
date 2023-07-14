// Напишите программу, которая принимает на вход 
// число и выдает количество цифр в числе
// Например: 89126 -> 5

Console.WriteLine("Введите любое многозначное число: ");
int number = int.Parse(Console.ReadLine());

int count = GetCountDigits(number);
Console.Write($"Количество цифр в числе {number} = {count}");

int GetCountDigits(int num)
{
    if (num == 0) return 1;

    int counter = 0;
    while (num  != 0)
    {
        num /= 10; // num = num / 10
        counter++;
    }
    return counter;
}