// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.

// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] CreateMatrixSumIndexes(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];

    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
        matrix[m, n] = m + n;
        }
    }
    return matrix;
}
    

void PrintMatrix(int[,] matrix)
{
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
    Console.Write("[ ");
    for (int n = 0; n < matrix.GetLength(1); n++)
    {
        Console.Write($"{matrix[m, n], 5} ");
    }
    Console.WriteLine("]    ");
    }
}

int[,] array2d = CreateMatrixSumIndexes(3, 4);
PrintMatrix(array2d);