// Задача 8: Напишите программу, 
// которая на вход принимает число (N), 
// а на выходе показывает 
// все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите целое положительное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 0)
{
    Console.WriteLine("Ошибка ввода");
}
else
{ 
    int counter = 2;
    while(counter <= num)
    {
        Console.Write(counter + " ");
        counter = counter + 2;
    }
}