/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/


int[,] matrix = GetSpiralMatrix(4, 4);
PrintSpiralMatrix(matrix);
System.Console.WriteLine();


int[,] GetSpiralMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];

    int number = 1;
    int startPositionRow = 0;
    int startPositionColumns = 0;
    int endPositionRow = rows - 1;
    int endPositionColumns = columns - 1;


    while (startPositionRow <= endPositionRow && startPositionColumns <= endPositionColumns)
    {
        for (int i = startPositionColumns; i <= endPositionColumns; i++)
        {
            matrix[startPositionRow, i] = number++;
        }
        startPositionRow++;

        for (int i = startPositionRow; i <= endPositionRow; i++)
        {
            matrix[i, endPositionColumns] = number++;
        }
        endPositionColumns--;

        for (int i = endPositionColumns; i >= startPositionColumns; i--)
        {
            matrix[endPositionRow, i] = number++;
        }
        endPositionRow--;

        for (int i = endPositionRow; i >= startPositionRow; i--)
        {
            matrix[i, startPositionColumns] = number++;
        }
        startPositionColumns++;
    }
    return matrix;
}

void PrintSpiralMatrix(int[,] matrix)
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


