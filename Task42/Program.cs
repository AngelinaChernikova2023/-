// Напишите программу, которая
// будет преобразовывать десятичное число в двоичное
// Делим на два, пока не дойдет до нуля

Console.WriteLine("Введите число, которое необходимо перевести в двоичную систему: ");
int number = int.Parse(Console.ReadLine());

int result = DecToBin(number);
Console.WriteLine($"Число в двоичном представлении = {result}");

int DecToBin(int number)
{
    int numResult = 0;
    int decimalBase = 1;
    while (number > 0) 
    {
      numResult += number % 2 * decimalBase;
      number /=2;
      decimalBase *=10;
    }
    return numResult;
}