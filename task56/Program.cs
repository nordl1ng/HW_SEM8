// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

System.Console.WriteLine("Введите количество строк массива m:");
int m = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов массива n:");
int n = Int32.Parse(System.Console.ReadLine());

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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write((matrix[i, j] + "\t"), 3);
        }
        System.Console.WriteLine();
    }
}

int MinSummLine(int[,] matrix)
{
    int line = 0;
    int summin = int.MaxValue;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summ = summ + matrix[i, j];
        }
        if (summ < summin)
        {
            summin = summ;
            line = i;
        }
        // System.Console.WriteLine($"Сумма {i} строки = {summ}");
    }
    System.Console.WriteLine($"Минимальная сумма элементов равна {summin}, находится в строке {line+1}");
    return summin;
}

int[,] arr = CreateMatrix(m, n);
System.Console.WriteLine("Массив чисел:");
PrintMatrix(arr);
MinSummLine(arr);
