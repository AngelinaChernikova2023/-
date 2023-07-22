// Задайте одномерный массив из 123 случаный чисел.
// Найдите количество элементов массива, значения которых
// лежат в отрезке (10 - 99).
// Пример: для 5 элементов, будем делать для 123 элементов
// [5, 18, 123 , 6, 2]-> 1 элемент

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
void PrintArray (int[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.Write("]    ");
}

int CountTwoDigitNumbers (int[] arr)
{   int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {   
        if(arr[i] >=10 && arr[i] < 99)
        count ++;       
    }
    return count;
}

Console.WriteLine();

int[] array = CreateArrayRndInt(123, -200, 200);
PrintArray(array);

Console.WriteLine();

int countTwoDigitNumbers = CountTwoDigitNumbers(array);
Console.WriteLine($"Количество двузначных чисел : {countTwoDigitNumbers}");