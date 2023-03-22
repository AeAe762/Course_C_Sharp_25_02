// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
//вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] Create_Array(int row, int column, int from, int to)
{
  double[,] array = new double[row, column];
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < column; j++)
    {
      array[i, j] = new Random().Next(from, to);
    }
  }
  return array;
}

void Print(double[,] array)
{
  double row = array.GetLength(0);
  double column = array.GetLength(1);
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < column; j++)
    {
      Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
  }
  Console.WriteLine();
}

Console.Write($"Введите количестов строк: ");
int row_1 = int.Parse(Console.ReadLine()!);
Console.Write($"Введите количестов столбцов: ");
int column_1 = int.Parse(Console.ReadLine()!);
Console.Write($"Введите число начала массива: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write($"Введите число конца массива: ");
int stop = int.Parse(Console.ReadLine()!);
double[,] massive = Create_Array(row_1, column_1, start, stop);
Console.WriteLine();
Console.WriteLine($"Двумерный массив:");
Print(massive);