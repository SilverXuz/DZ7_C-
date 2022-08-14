/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

(1,7) -> такого числа в массиве нет
*/

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату элемента по оси X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату элемента по оси Y: ");
int y = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n,m];
void Array(int[,] matrix)
{
    for (int i = 0; i < n; i++)
    {

        for (int j = 0; j < m; j++)
        {
            matrix[i, j] = new Random().Next(0,100);
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
}

Array(matrix);
Console.WriteLine();
if (x < n || y < m)
    Console.WriteLine("Число -> " + matrix[x - 1, y - 1]);
else
    Console.Write(" -> такого числа нет");
