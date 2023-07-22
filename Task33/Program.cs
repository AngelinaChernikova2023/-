// Задайте массив. Напишите программу, 
// которая определяет присутствует ли 
// заданное число в массиве.
// Например: 4; массив [6, 7, 19, 345, 3] -> нет
//           3; массив [6, 7, 19, 345, 3] -> да

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

bool FindNumberInArray (int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == num)
        return true;
    }
    return false;
}

Console.WriteLine();

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);

Console.WriteLine();

bool isExistNumber = FindNumberInArray(array, 6);
Console.WriteLine(isExistNumber? "Да" : "Нет");