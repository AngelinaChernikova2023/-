// Не используя рекурсию, 
// выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 01123
// Если N = 7 -> 0112358

// int size = Convert.ToInt32(Console.ReadLine());

int[] Fibonacci(int num)
{
    int[] array = new int[num];
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i-1] + array[i-2];
    }
    return array;
}

void PrintArray(int[] arr)
{

    Console.Write("[ ");

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
        if (i == arr.Length - 1)
        {
            break;
        }
        Console.Write(" ");
    }
    Console.WriteLine(" ]    ");
}


Console.WriteLine("Введите размер для массива");
int size = Convert.ToInt32(Console.ReadLine());
PrintArray(Fibonacci(size));