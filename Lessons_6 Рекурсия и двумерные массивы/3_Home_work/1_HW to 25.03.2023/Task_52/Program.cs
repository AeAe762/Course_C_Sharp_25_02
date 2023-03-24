// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
//элементов в каждом столбце.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] Create_Array(int row, int column, int from, int to)
{
  int[,] array = new int[row, column];

  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < column; j++)
    {
      array[i, j] = new Random().Next(from, to);
    }
  }
  return array;
}

void Print(int[,] array)
{
  int row = array.GetLength(0);
  int column = array.GetLength(1);
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

void Srednee_column(int[,] arr)
{
  double summa = 0;
  double result = 0;
  for (int j = 0; j < arr.GetLength(1); j++)
  {
    for (int i = 0; i < arr.GetLength(0); i++)
    {
      summa = summa + arr[i, j];
    }
    result = Math.Round(summa / arr.GetLength(0), 1);
    Console.Write($"{result}; ");
    summa = 0;
  }
}

Console.Write($"Введите количестов строк: ");
int row_1 = int.Parse(Console.ReadLine()!);
Console.Write($"Введите количестов столбцов: ");
int column_1 = int.Parse(Console.ReadLine()!);
Console.Write($"Введите число начала массива: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write($"Введите число конца массива: ");
int stop = int.Parse(Console.ReadLine()!);
int[,] massive = Create_Array(row_1, column_1, start, stop);
Console.WriteLine();
Console.WriteLine($"Двумерный массив:");
Print(massive);
Srednee_column(massive);

