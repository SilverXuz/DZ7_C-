/* Транспонирование - 4
Задана целочисленная матрица, состоящая из N строк и M столбцов.
Требуется транспонировать ее относительно горизонтали.
*/

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
void Array(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0,100);
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
}

void TranceArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1) / 2; j++)
        {
            int x = matrix[i, j];
            matrix[i, j] = matr[matr.GetLength(1) - i - 1, j];
            matr[matr.GetLength(1) - i - 1, j] = x;            
        }
    }
    for (int i = 0; i < matr.GetLength(0); i++)
    {
            for (int j = 0; j < matr.GetLength(1); j++)
        {
           Console.Write(matr[matr.GetLength(1) - i - 1, j] + " \t");
            
        }
        Console.WriteLine();
    }
}

Array(matrix);
Console.WriteLine();
TranceArray(matrix);