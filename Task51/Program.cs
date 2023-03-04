// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д.)
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(minValue,maxValue+1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int m = 0; m < matr.GetLength(1); m++)
        {
            Console.Write(matr[i,m]+ "\t");
        }
        Console.WriteLine();
    }
}
int[,] resultMatrix = GetMatrix(4, 4, 0, 10);
PrintMatrix(resultMatrix);
void Diagonal(int[,] inputMatrix)
{
    int sumDiagonal=0; 
    for (int i = 0; i < inputMatrix.GetLength(1); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(0); j++)
        {
            if (i==j)
            {
                sumDiagonal=sumDiagonal+inputMatrix[i,j];
            }
            
        }
    }
    Console.WriteLine($"Сумма элементов главной диагонали: {sumDiagonal}");
}
Diagonal(resultMatrix);