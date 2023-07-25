// Напишите программу, которая принимает на вход три числа 
// и проверяет, 
// может ли существовать треугольник
// со сторонами такой длины

//Каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

bool isTriagle = IsTriagleExists(num1, num2, num3);
Console.WriteLine(isTriagle? "Треугольник существует" : "Треугольник не существует");

bool IsTriagleExists(int a, int b, int c)
// {
//     if (a < b + c && b < a + b && c < a + b)
//     return true;
// return false;
// }
{
    return a < b + c && b < a + b && c < a + b;
}


