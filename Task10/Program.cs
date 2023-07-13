//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число от 100 до 999 {number}");
int firstDight = number / 100;
int thirdDight = number % 10;
int resultDight = firstDight * 10 + thirdDight;
Console.WriteLine($"Получено двузначное число {resultDight}");

//ИЛИ
//int RemoveSecondDigit (int number)
//{
//    int firstDight = number/100;
//int thirdDight = number % 10;
//int resultDight = firstDight *10 + thirdDight;
//return resultDight;
//}
