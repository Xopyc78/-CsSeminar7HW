// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
int[,] resultMatrix = GetMatrix(3, 4, 0, 10);
PrintMatrix(resultMatrix);
void ArithmeticMean(int[,] inputMatrix)
{
    
    for (int j = 0; j < inputMatrix.GetLength(1); j++)
    {
        double sumColumns=0;
        for (int i = 0; i < inputMatrix.GetLength(0); i++)
        {
            sumColumns=sumColumns+inputMatrix[i,j];
        }
        Console.WriteLine($"Среднее арифметическое {j} столбца: {Math.Round(sumColumns/inputMatrix.GetLength(0),2)}");
    }
}
ArithmeticMean(resultMatrix);