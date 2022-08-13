// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
double [,] matrix = new double[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(-100, 100);
    }
}    
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
        Console.Write(matrix[i, j] + "    ");
    Console.WriteLine();
    Console.WriteLine();
}
