// Напишите программу, которая
// принимает на вход число (А) и выдает произведение чисел
// от 1 до А.

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

int factorial = Factorial(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {factorial}");

int Factorial(int num)

{
    int fact = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
          fact *= i; // fact = fact * i
        }
      
    }
return fact;
}
