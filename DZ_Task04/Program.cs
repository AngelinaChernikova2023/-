// Задача 4: Напишите программу, 
// которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число 1");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = num;
if (num > max) max = num;
if (num1 > max) max = num1;
if (num2 > max) max = num2;
Console.WriteLine($"max = {max}");
