// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int[,] Create_array (int row, int column, int from, int to)
{
  int[,] array = new int[row, column];
  for (int i = 0; i < column; i++)
    for (int j = 0; j < row; j++)
      array[i,j] = new Random().Next(from, to);
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
      Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }  
  Console.WriteLine();
}
void Example (int[,] arr, int num_1, int num_2)
{
 if  (num_1 > arr.GetLength(0) || num_2 > arr.GetLength(1))
  Console.WriteLine("Такого числа в массиве нет");
else Console.WriteLine($"Заданая позиция ровна числу {arr[num_1 - 1, num_2 - 1]} массива");
}





Console.Write($"Введите количестов строк: ");
int row_1 = int.Parse(Console.ReadLine()!);
Console.Write($"Введите количестов столбцов: ");
int column_1 = int.Parse(Console.ReadLine()!);
Console.Write($"Введите число начала массива: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write($"Введите число конца массива: ");
int stop = int.Parse(Console.ReadLine()!);
Console.Write($"Введите строку: ");
int numm = int.Parse(Console.ReadLine()!);
Console.Write($"Введите столбец: ");
int numm_1 = int.Parse(Console.ReadLine()!);
int[,] massive = Create_array(row_1, column_1, start, stop);
Console.WriteLine();
Console.WriteLine($"Двумерный массив:");
Print(massive);
Example(massive, numm, numm_1);

