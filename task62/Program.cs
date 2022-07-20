// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7
System.Console.WriteLine("Введите количество строк и столбцов массива:");
int n = Int32.Parse(System.Console.ReadLine());
int number = 1;

int[,] CreateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-9, 10);
        }
    }
    return matrix;
}

void SpiralMatrix (int [,] array)
{
for (int i = 0; i <= n / 2; i++)
{
    for (int j = i; j < n - i; j++)
    {
        array[i, j] = number++;
    }
    for (int k = i + 1; k < n - i; k++)
    {
        array[k, n - 1 - i] = number++;
    }
    for (int j = n - i - 2; j >= i; j--)
    {
        array[n - 1 - i, j] = number++;
    }
    for (int k = n - 2 - i; k > i; k--)
    {
        array[k, i] = number++;
    }
}
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write((matrix[i, j] + "\t"), 0);
        }
        System.Console.WriteLine();
    }
}
System.Console.WriteLine();
int[,] array = CreateMatrix(n,n);
SpiralMatrix(array);
PrintMatrix(array);