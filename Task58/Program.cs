/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] matrixA = GetRandomMatrix(2, 2);
int[,] matrixB = GetRandomMatrix(2, 3);
Console.WriteLine("Матриса А:");
PrintMatrix(matrixA);
System.Console.WriteLine();
Console.WriteLine("Матриса B:");
PrintMatrix(matrixB);
System.Console.WriteLine();
int[,] matrixC = GetMultiplicationMatrix(matrixA, matrixB);


int[,] GetRandomMatrix(int rows, int columns)
{ 
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(1,10);
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


int[,] GetMultiplicationMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    if (matrixA.GetLength(0) == matrixB.GetLength(1))
    {
        
        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                for (int z = 0; z < matrixB.GetLength(0); z++)
                {
                    matrixC[i, j] += matrixA[i, z] * matrixB[z, j];
                }
            }
        }
        System.Console.WriteLine("Произведение матриц А и В равно:"); 
        PrintMatrix(matrixC);   
    }
    else 
    { 
        System.Console.WriteLine("Невозможно найти произведение матриц, строки матрицы А не соответствует столбцам матрицы В");
        matrixC = null; 
    
    }
    return matrixC;
    

}






