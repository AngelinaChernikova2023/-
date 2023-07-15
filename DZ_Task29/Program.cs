// Напишите программу, которая задает массив из 8 элементов,
// заполненный псевдослучайными числами и выводит их на экран.

int[] array = new int[8]; // по умолчанию массив заполняется нулями 00000000
FillArray(array);

void FillArray (int[] arr)
{   Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-1000, 1000); // arr[i] = new Random().Next(2)
    }
} 

PrintArray(array);
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

//