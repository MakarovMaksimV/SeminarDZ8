/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] matrix = GetRandomMatrix(4, 4);
PrintMatrix(matrix);
System.Console.WriteLine();
int[] sum = GetMinRowsSum(matrix);
PrintMin(sum);
Console.ReadKey();

int[,] GetRandomMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
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
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void PrintMin(int[] sum)
{
    int minVal = sum.Min();
    int indexMin = Array.IndexOf(sum, minVal) + 1;
    System.Console.WriteLine("Minimum sum of elements in a row: " + sum.Min());
    System.Console.WriteLine("Row with the minimum sum of elements is: " + indexMin);
}

int[] GetMinRowsSum(int[,] matrix)
{
    int[] sum = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum[i] += matrix[i, j];
        }
    }
    return sum;
}