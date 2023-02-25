using System.Numerics;
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
int[,] matrixA = new int[3, 3];
int[,] matrixB = new int[3, 3];

Console.Clear();
FillArrayMatrixA();
PrintArrayMatrixA();
Console.WriteLine();
FillArrayMatrixB();
PrintArrayMatrixB();
Console.WriteLine();
MultiplicationArray(matrixA, matrixB);

void FillArrayMatrixA()
{
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)
        {
        matrixA[i, j] = new Random().Next(1, 10);
        }
    }   
}

void PrintArrayMatrixA()
{
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)
        {
        Console.Write(matrixA[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FillArrayMatrixB()
{
    for (int i = 0; i < matrixB.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
        matrixB[i, j] = new Random().Next(1, 10);
        }
    }   
}

void PrintArrayMatrixB()
{
    for (int i = 0; i < matrixB.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
        Console.Write(matrixB[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void MultiplicationArray(int[,] matrixA, int[,] matrixB)
{
    int[,] result = new int[3, 3];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int sum = 0;
            sum += matrixA[i, j] * matrixB[i, j];
            result[i, j] = sum;
        }
    }
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            Console.Write($"{result[i, j]} ");
        }
        Console.WriteLine();
    }
}