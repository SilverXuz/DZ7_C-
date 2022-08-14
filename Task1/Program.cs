/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[n,m];
void Array(double[,] matrix)
{
    for (int i = 0; i < n; i++)
    {

        for (int j = 0; j < m; j++)
        {
            matrix[i, j] = new Random().Next(-100,100) * new Random().NextDouble();
            matrix[i, j] = Math.Round(matrix[i, j], 2);
            Console.Write(matrix[i, j] + " \t");

        }
        Console.WriteLine(" \t");
    }
}

Array(matrix);