// Напишите программу, которая выводит
// случайное число из диапазона [10 - 99] 
// и показывает наибольшую цифру числа

int num = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из диапазона 10 - 99 -> {num}");
int firstDigit = num / 10; // 78 / 10 = 7
int secondDigit = num % 10; // 78 % 10 = 8
if (firstDigit > secondDigit)
Console.WriteLine($"Максимальная цифра числа {firstDigit}");
else Console.WriteLine($"Максимальная цифра числа {secondDigit}");