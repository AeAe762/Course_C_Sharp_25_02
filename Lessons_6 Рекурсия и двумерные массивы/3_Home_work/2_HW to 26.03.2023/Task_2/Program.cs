// Задача 2: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.



int[,] Create_array(int row, int column, int from, int to)
{
  int[,] array = new int[row, column];
  for (int i = 0; i < column; i++)
    for (int j = 0; j < row; j++)
      array[i, j] = new Random().Next(from, to);
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

void Sort_elements (int[,] arr)
{
  int row = arr.GetLength(0);
  int column = arr.GetLength(1);

  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < column; j++)
    {
      for (int k = 0; k < column - j - 1; k++) 
        if (arr[i, k] < arr[i, k + 1])
          (arr[i, k], arr[i, k + 1]) = (arr[i, k + 1], arr[i, k]);
    }        
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
int[,] massive = Create_array(row_1, column_1, start, stop);
Console.WriteLine();
Console.WriteLine($"Двумерный массив:");
Print(massive);
Sort_elements(massive);
Console.WriteLine($"Отсортированный двумерный массив:");
Print(massive);







