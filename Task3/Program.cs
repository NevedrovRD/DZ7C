// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int[m, n];
double [] array = new double[n];
for (int j = 0; j < n; j++)
{
    for (int i = 0; i < m; i++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        array[j] += matrix[i, j]; 
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
        Console.Write(matrix[i, j] + "    ");
    Console.WriteLine();
    Console.WriteLine();
}

for (int j = 0; j < n; j++)
    Console.Write("" + string.Join(", " , array[j] / 3) + ";  ");

