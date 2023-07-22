// Напишите программу замены элементов массива: 
// положительных элементы замените на отрицательные
// и наоборот

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

void InverseArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
}
Console.WriteLine();

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);

Console.WriteLine();

InverseArray(array);
PrintArray(array);





