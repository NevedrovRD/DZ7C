// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер строки ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца ");
int y = Convert.ToInt32(Console.ReadLine());


int [,] matrix = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(0, 100);
    }
}
 for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
        Console.Write(matrix[i, j] + "    ");
    Console.WriteLine();
    Console.WriteLine();
}
if (x <= m - 1 && y <= n - 1)
{
    Console.WriteLine(matrix[x, y]);
}
else
    Console.WriteLine("Такого элемента нет!");