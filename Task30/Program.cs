// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// 0 1 0 0 1 1 1 0

// for (int i = 0; i < array.Length; i++) //Lenght - Длина(количество элементов в массиве)
// {
//     array[i] = i * i;
//     Console.Write(array[i] + " ");
// }

int[] array = new int[8]; // по умолчанию массив заполняется нулями 00000000
FillArray(array);

void FillArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(2); // arr[i] = new Random().Next(0, 2)
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

