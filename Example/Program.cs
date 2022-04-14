// 48. Показать двумерный массив размером m×n заполненный целыми числами
int[,] CreateArray(int m, int n, int LeftB, int RightB)
{
    int[,] arrayMatrix = new int[m, n];
    for (int i = 0; i < arrayMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < arrayMatrix.GetLength(1); j++)
        {
            arrayMatrix[i, j] = new Random().Next(LeftB, RightB);
        }
    }
    return arrayMatrix;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}


// //PrintArray(CreateArray(2, 4));
// 49. Показать двумерный массив размером m×n заполненный вещественными числами
double[,] CreateDoubleArray(int m, int n)
{
    double[,] arr = new double[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().NextDouble();

        }
    }
    return arr;
}

void PrintDoubleArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
//PrintDoubleArray(CreateDoubleArray(2, 6));

// 50. В двумерном массиве n×k заменить четные элементы на противоположные

int[,] ReplaceOddElements(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] % 2 == 0)
                array[i, j] = -array[i, j];
        }

    }
    return array;
}


// int[,] array1 = CreateArray(2, 5, 0, 100);
// PrintArray(array1);
// Console.WriteLine();
// ReplaceOddElements(array1);
// PrintArray(array1);

// 51. Задать двумерный массив следующим правилом: Aₘₙ = m+n


// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

int[,] ReplaceTwoIndexOdd(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
                array[i, j] = array[i, j] * array[i, j];
        }

    }
    return array;
}
// ReplaceTwoIndexOdd(array1);
// PrintArray(array1);

53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int indexI = -1;
int indexJ = -1;
int[] SeachIndex(int[,] array)
{
    int[] newArray = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                indexI = i;
                indexJ = j;
                newArray[0] = indexI;
                newArray[1] = indexJ;
            }

        }
    }
    if (newArray[0] == -1)
    {
        Console.WriteLine("Такого числа нет");
    }
    return newArray;
}

void PrintArray1(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
}
SeachIndex(array1);

