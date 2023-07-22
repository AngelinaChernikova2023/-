// // Задайте массив из 12 элементов заполненный случайными числами из промежутка
// от [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6]
// сумма полижительный числе равна 29,
// сумма отрицательных чисел равна -20.

// Предыдущая аналогичная задача, без счета суммы.
// int[] array = new int[12]; // по умолчанию массив заполняется нулями 00000000
// FillArray(array);

// void FillArray (int[] arr)
// {   Random rnd = new Random(); //избегание повторяющихся чисел
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(-9, 9); // arr[i] = new Random().Next(0, 2)
//     }
// } 

// PrintArray(array);
// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
// }

//Текущая задача

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

int SumPositiveElem(int[] arr)
{
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] >= 0) sum += arr[i];
}
return sum;
}

int SumNegativeElem(int[] arr)
{
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < 0) sum += arr[i];
}
return sum;
}

int[] SumPositiveNegativeElem(int[] arr)
{
    int sumNegativeElem = 0;
    int sumPositiveElem = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sumPositiveElem += arr[i];
        }
        else
        {
            sumNegativeElem += arr[i];
        }
    }
    return new int []{sumPositiveElem, sumNegativeElem};
}

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
int sumPositiveElem = SumPositiveElem(array);
int sumNegativeElem = SumNegativeElem(array);

Console.WriteLine($"Сумма положительных элементов равна {sumPositiveElem}");
Console.WriteLine($"Сумма отрицательных элементов равна {sumNegativeElem}");

int[] sumPositiveNegativeElem = SumPositiveNegativeElem(array);
Console.WriteLine($"Сумма положительных элементов равна {sumPositiveElem}");
Console.WriteLine($"Сумма отрицательных элементов равна {sumNegativeElem}");
