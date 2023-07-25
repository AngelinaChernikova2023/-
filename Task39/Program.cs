// Напишите программу, которая перевернет
// одномерный массив (последний элемент будет на первом
// месте, а первый на последнем и т.д.)
// [1,2,3,4,5] -> [5,4,3,2,1]

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
// [1 2 3 4 5] -> [5 4 3 2 1]
void ReversArray (int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}

int[] array = CreateArrayRndInt(5, -9, 9);
PrintArray(array);
Console.WriteLine();
ReversArray(array);
PrintArray(array);
Console.WriteLine();

//Встроенный метод!!!
Array.Reverse(array);
PrintArray(array);

