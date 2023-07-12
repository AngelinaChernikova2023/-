//Напишите программу, которая на вход принимает число
//(N), а на выходе показывает все целые числа в промежутке от
//- (N) до (N)
// Например:
// 4 -> -4, -3, -2, -1, 0, 1, 2, 3, 4

Console.WriteLine("Введите целое положительное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 0)
{
    Console.WriteLine("Ошибка ввода");
}
else
{
    int counter = -num;
    while(counter <= num)
    {
        Console.Write(counter + " ");
        counter = counter + 1;
    }
}