// Задача 1: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на пересечении которых 
// расположен наименьший элемент массива.


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
int[] Min_number(int[,] arr)
{
  int min_num = arr[0, 0];
  int row = arr.GetLength(0);
  int column = arr.GetLength(1);
  int[] index = new int[2];

  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < column; j++)
    {
      if (min_num > arr[i, j])
      {
        min_num = arr[i, j];
        index[0] = i;
        index[1] = j;
      }
    }
  }
Console.WriteLine($" Минимальное число массива = {min_num}");
return index;
 
}
void New_arr(int[,] arr, int[] index)
{
  int row = arr.GetLength(0);
  int column = arr.GetLength(1);

  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < column; j++)
    {
      if (index[0] == i || index[1] == j) continue;
      else
        Console.Write($"{arr[i,j]} ");
    
    }
    Console.WriteLine();
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
int[,] massive = Create_array(row_1, column_1, start, stop);
Console.WriteLine();
Console.WriteLine($"Двумерный массив:");
Print(massive);
Min_number(massive);
int[] massive_1 = Min_number(massive);
New_arr(massive, massive_1);