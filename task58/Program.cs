// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

System.Console.WriteLine("Введите количество строк Массива A:");
int m1 = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов Массива А:");
int n1 = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine("Введите количество строк Массива B:");
int m2 = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов Массива B:");
int n2 = Int32.Parse(System.Console.ReadLine());

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
int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] matrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
           for (int k = 0; k < matrixB.GetLength(0); k++)
           {
            matrix[i, j] += matrixA[i,k]*matrixB[k,j];
           } 
        }
    }
    return matrix;
}
if (n1==m2)
{
int[,] arrA = CreateMatrix(m1, n1);
int[,] arrB = CreateMatrix(m2, n2);
System.Console.WriteLine("Массив А:");
PrintMatrix(arrA);
System.Console.WriteLine();
System.Console.WriteLine("Массив B:");
PrintMatrix(arrB);
System.Console.WriteLine();
int[,] arrC=MatrixMultiplication(arrA,arrB);
System.Console.WriteLine("Результат - Массив С");
PrintMatrix(arrC);
}
else
{
    System.Console.WriteLine("Матрицы нельзя перемножить");
}