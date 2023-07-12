// Напишите программу, которая 
// 1. на вход принимает число 
// 2. и выдает его квадрат.
// например: 4 -> 16

Console.WriteLine ("Введите число");
string str = Console.ReadLine();
int num = Convert.ToInt32(str);
int Square = num * num;
Console.WriteLine (Square);

