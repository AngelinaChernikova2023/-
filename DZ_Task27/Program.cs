// Напишите программу, которая принимает на вход число и 
// выдает сумму цифр в числе.
// Например:
// 452 -> 11
// 82 -> 10


Console.WriteLine("Введите целое положительное число: ");
int a = Convert.ToInt32(Console.ReadLine());

int len = Length(a);
Console.Write($"Сумма цифр в числе {a} равно: {Sum(a,len)}");

int Length(int a) // Подсчет количества символов в числе
{
int index = 0;
while (a > 0)
{
a /= 10;
index++;
}
return index;
}

int Sum(int a, int len)
{
int sum = 0;
for (int i = 1; i <= len; i++)
{
sum += a % 10;
a /= 10;
}
return sum;
}

// int result(int num)
// {
// int a = number / 100;
// int b = number / 10 % 10;
// int c = number % 10;
// {
// result = a + b + c;
// }
// return;
// }
// Console.WriteLine(result);


// int sumNumbers = SumNumbers(number);
// Console.WriteLine($"Сумма чисел {number} = {sumNumbers}");

// int SumNumbers(int num)

// {
//     int sum = 0;
//     for (int i = 1; i <= num; i++)
//     {
//         sum += i; // sum = sum + 1
//     }
// return sum;
// }