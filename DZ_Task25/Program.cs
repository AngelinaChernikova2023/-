// Напишите цикл, который принимает на  вход два числа
// (А и В) и возводит число А в натуральную степень В.
// Например:
// 3, 5 -> 243

Console.WriteLine("Введите целое число А");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое число В");
int num1 = Convert.ToInt32(Console.ReadLine());

double Square = Math.Pow(num, num1);
Console.WriteLine ($"Квадрат числа А возведенный в степень числа В = {Square}");

