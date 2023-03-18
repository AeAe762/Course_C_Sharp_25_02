// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] Fill_Array(int size, int from, int to)
{
  int[] array = new int[size];
  for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(from, to);
  return array;
}
void Print(int[] num)
{
  for (int i = 0; i < num.Length; i++) Console.Write($"{num[i]} ");
}
double MaxMinNum(int[] num_1)
{
  int max = 0;
  int min = 0;
  for (int i = 0; i < num_1.Length; i++)
  {
    for (int j = 1; j < num_1.Length; j++)
    {
      if (num_1[j] > num_1[i] && max < num_1[j])
      {
        max = num_1[j];
        min = num_1[i];
      }
      else if (num_1[j] < min) min = num_1[j];
    }
  }
  Console.WriteLine($"max = {max}");
  Console.WriteLine($"min = {min}");
  Console.WriteLine();
  double result = max - min;
  Console.Write($"Ответ: ");
  return result;
}
int size = int.Parse(Console.ReadLine()!);
int from = int.Parse(Console.ReadLine()!);
int to = int.Parse(Console.ReadLine()!);
int[] res = Fill_Array(size, from, to);
Print(res);
Console.WriteLine();
Console.WriteLine(MaxMinNum(res));

