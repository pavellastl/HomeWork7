using System;
using static System.Console;
Clear();
double[,] GetArray(int m, int n, int minValue, int maxValue)
{
double[,] result = new double[m, n];
for (int i = 0; i < m; i++)
{
for (int j = 0; j < n; j++)
{
result[i, j] = new Random().NextDouble();
}
}
return result;

}

void PrintArray(double[,] inArray)
{
for (int i = 0; i < inArray.GetLength(0); i++)
{
for (int j = 0; j < inArray.GetLength(1); j++)
{
Write($"{inArray[i,j]} ");
}
WriteLine();
}
}
WriteLine("Введите колличество строк");
int rows = int.Parse(ReadLine()!);
WriteLine("Введите колличество столбцов");
int colomns = int.Parse(ReadLine()!);
double[,] array = GetArray(rows, colomns, 0, 9);
PrintArray(array);
