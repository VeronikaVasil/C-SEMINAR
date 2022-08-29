// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

Console.Write("Введите количество строк:  ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов:  ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
for (int m = 0; m < rows; m++)
{
    for (int n = 0; n < columns; n++)
    {
        array[m, n] = m + n;
        Console.Write(array[m, n]+ "\t");
    }
    Console.WriteLine();
}