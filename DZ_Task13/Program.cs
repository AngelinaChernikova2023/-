// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите любое многозначное число: ");
int number = int.Parse(Console.ReadLine());

if (number < 100)
{
Console.WriteLine("Третьей цифры нет");
}
if (number >= 100 && number <=999)
{
    int thirdNumber = number % 10;
    Console.WriteLine($"Третья цифра числа: {thirdNumber}");
}
else 
{   
    while (number >= 100 && number <=999)
{
    int number1 = number / 10;
    Console.WriteLine($"Третья цифра числа: {number1}");
    return;
}
}

// {
//     while 
//         number /= 10;
//     }
//     return number % 10;
// }
// // int count = GetCountDigits(number);
// // Console.Write($"Количество цифр в числе {number} = {count}");

// // int GetCountDigits(int number);
// // while (count <= 3);
// // {
// //     if (number == 0) return 1;

// //     int counter = 0;
// //     while (number  != 0)
// //     {
// //         number /= 10; // num = num / 10
// //         counter++;
// //     }
// //     return counter;
// // }
// // int Console.WriteLine( {GetCountDigits} );