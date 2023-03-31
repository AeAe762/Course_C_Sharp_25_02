// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей
// суммой элементов: 1 строка




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

int[] Summa_row(int[,] arr)
{
  int row = arr.GetLength(0);
  int column = arr.GetLength(1);
  int[] array_1 = new int[arr.GetLength(0)];

  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < column; j++)
    {
      array_1[i] += arr[i, j];
    }
  }
  return array_1;
}

void Find_min(int[] arr)
{
  int min_num = 0;
  for (int i = 1; i < arr.Length; i++)
  {
    if (arr[i] < arr[min_num]) min_num = i;
  }

  Console.WriteLine($"Сумма минимальных елементов: {arr[min_num]}, находится на строке: {min_num + 1}");
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
// Summa_row(massive);
int[] massive_1 = Summa_row(massive);
Find_min(massive_1);







