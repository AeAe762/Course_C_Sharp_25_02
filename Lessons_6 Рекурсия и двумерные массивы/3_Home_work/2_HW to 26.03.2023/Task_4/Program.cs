// Задача 4: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateFirstMatrix(int row, int column, int from, int to)
{
  int[,] array = new int[row, column];
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < column; j++)
      array[i, j] = new Random().Next(from, to);
  }
  return array;
}


int[,] CreateSecondMatrix(int row1, int column1, int from1, int to1)
{
  int[,] array1 = new int[row1, column1];
  for (int i = 0; i < row1; i++)
  {
    for (int j = 0; j < column1; j++)
      array1[i, j] = new Random().Next(from1, to1);
  }
  return array1;
}



int[,] MultiMatrix(int[,] first_mass, int[,] second_mass)
{
  int row = first_mass.GetLength(0);
  int column = first_mass.GetLength(1);

  int row_2 = second_mass.GetLength(0);
  int column_2 = second_mass.GetLength(1);

  int[,] multi = new int[row, column];

  if (column == row_2)
    multi = new int[row, column_2];
  else if (column != row_2) return multi;

  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < column_2; j++)
    {
      for (int p = 0; p < column; p++)
        multi[i, j] += first_mass[i, p] * second_mass[p, j];
    }
  }
  return multi;
}

void Print(int[,] array)
{
  int row = array.GetLength(0);
  int column = array.GetLength(1);
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < column; j++)
      Console.Write($"{array[i, j]} ");
    Console.WriteLine();
  }
  Console.WriteLine();
}

Console.Write($"Введите количестов строк Матрицы 1: ");
int row_1 = int.Parse(Console.ReadLine()!);
Console.Write($"Введите количестов столбцов Матрицы 1: ");
int column_1 = int.Parse(Console.ReadLine()!);
Console.Write($"Введите диапозон from для 1 матрицы: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write($"Введите диапозон to для 1 матрицы: ");
int stop = int.Parse(Console.ReadLine()!);
int[,] massive = CreateFirstMatrix(row_1, column_1, start, stop);

Console.Write($"Введите количестов строк Матрицы 2: ");
int row_2 = int.Parse(Console.ReadLine()!);
Console.Write($"Введите количестов столбцов Матрицы 2: ");
int column_2 = int.Parse(Console.ReadLine()!);
Console.Write($"Введите диапозон from для 2 матрицы: ");
int start_2 = int.Parse(Console.ReadLine()!);
Console.Write($"Введите диапозон to для 2 матрицы: ");
int stop_2 = int.Parse(Console.ReadLine()!);
int[,] massive2 = CreateSecondMatrix(row_2, column_2, start_2, stop_2);

Console.WriteLine();
Console.WriteLine($"Матрица 1");
Print(massive);
Console.WriteLine($"Матрица 2");
Print(massive2);
Console.WriteLine();
Console.WriteLine($"Результат произведения двух матриц:");
int[,] result = MultiMatrix(massive, massive2);
Print(result);