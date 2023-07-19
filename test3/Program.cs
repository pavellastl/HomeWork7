using System;
using static System.Console;
Clear();
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
int[,] result = new int[m, n];
for (int i = 0; i < m; i++)
{
for (int j = 0; j < n; j++)
{
result[i, j] = new Random().Next(minValue, maxValue + 1);
}
}
return result;
}
void PrintArray(int[,] inArray)
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
int ColomnsSum(int[,] array)
{
    
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        
        
        
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[i,j];
         
        }
        WriteLine($"Сумма Столбца №{i+1}={sum}");
        sum = 0;
    }

    return sum;
}
WriteLine("введите колличество рядов");
int rows = int.Parse(ReadLine());
WriteLine("введите колличество Столбцов");
int colomns = int.Parse(ReadLine());
int[,] matrix = GetArray(rows, colomns, 0, 9);
PrintArray(matrix);
ColomnsSum(matrix);