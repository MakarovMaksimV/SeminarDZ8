/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[, ,] matrix = GetRandomMatrix(2,2,2);
PrintMatrix(matrix);

int[, ,] GetRandomMatrix(int n, int m, int k )
{
    Random rnd = new Random();
    int[, ,] matrix = new int [n,m,k];
   
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for(int z = 0; z < k; z++)
            {
            matrix[i, j, z] = rnd.Next(10,100);
            
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[, ,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.ReadKey();
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                
                System.Console.Write(matrix[i,j,z]);
                System.Console.Write("{0},{1},{2}","(" + i, j, z + ")");
                Console.Write("\t");
                
            }
            Console.WriteLine();            
        }
    }

}