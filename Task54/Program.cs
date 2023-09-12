/*
Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/


System.Console.Write("Enter rows: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter columns: ");
int y = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter the minimum value of an array element: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter the maximum value of an array element: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] matrix = GetRandomMatrix(x, y, n, m);
PrintMatrix(matrix);
System.Console.WriteLine();
FromMinToMaxRowsMatrix(matrix);
PrintMatrix(FromMinToMaxRowsMatrix(matrix));

int[,] GetRandomMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue);
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

int[,] FromMinToMaxRowsMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(1) - 1; k++)
      {
        if (matrix[i, k] > matrix[i, k + 1])
        {
          int temp = matrix[i, k + 1];
          matrix[i, k + 1] = matrix[i, k];
          matrix[i, k] = temp;
        }
      }
    } 
  }
  return matrix;
}


