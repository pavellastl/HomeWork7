// не понял как исправить вывод, когда заданной позиции нет
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
int Findposition(int[,] array, int m, int n)
{
    int pos = array[0,0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if(pos == array[m,n])
        {
            pos = array[m,n];
            break;
        }
        for (int j = 0; j < array.GetLength(1); j++)
        {
            pos = array[i,j];
            if(pos == array[m,n])
            {
                pos = array[m,n];
                break;
            }
           
        }
    }
   if(m > array.GetLength(0) || n > array.GetLength(1))
   {
    WriteLine("Такого Элемента нет");
   }
   else
   {
    WriteLine($"Это элемент {pos}");
   }
    
    return pos;
}
WriteLine("Введите колличество строк");
int rows = int.Parse(ReadLine());
WriteLine("Введите колличество столбцов");
int colomns = int.Parse(ReadLine());
WriteLine("Введите ряд искомого элемента");
int rowElement = int.Parse(ReadLine());
WriteLine("Введите столбик искомого элемента");
int colomnsElement = int.Parse(ReadLine());
int[,] matrix = GetArray(rows, colomns, 0, 9);
PrintArray(matrix);
Findposition(matrix, rowElement, colomnsElement);