//  Задайте массив вещественных чисел. 
//  Найдите разницу между 
//  максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];

    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArrayDouble(double[] arr, int round = 2)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {   
        double num = Math.Round(arr[i], round);
        if (i < arr.Length - 1) Console.Write($"{num}| ");
        else Console.Write($"{num}");
    }
    Console.Write("]    ");
}
Console.WriteLine();

double[] arrDouble = CreateArrayRndDouble(10, 0, 100);
PrintArrayDouble(arrDouble);
Console.WriteLine();