// Напишите программу, которая 
// 1. на вход принимает два числа 
// 2. и проверяет является ли певрое число квадратом второго.
// например: a = 25, b = 5 -> Да

Console.WriteLine ("Введите первое целое число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе целое число");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num == num1 * num1)
{
 Console.WriteLine ( "Первое число является квадратом второго" );
}
else
{
    Console.WriteLine ( "Первое число не является квадратом второго" );
}

