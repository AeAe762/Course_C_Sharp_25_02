// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] Array(int size, int from, int to)
{
  int[] arr = new int[size];
  for (int i = 0; i < size; i++) arr[i] = new Random().Next(from, to);
  return arr;
}
void Print(int[] array){for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");}
void Pos_array(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0) count ++;
  }
  Console.WriteLine();
  if (count == 0) Console.WriteLine($"Положительных чисел нет");  
  Console.WriteLine($"Количество положительных чисел = {count}");
}

int size = int.Parse(Console.ReadLine()!);
int from = 100; //int.Parse(Console.ReadLine()!);
int to =  1000; //int.Parse(Console.ReadLine()!);
int[] res = Array(size, from, to);
// res[0] = 345;
// res[1] = 897;
// res[2] = 568;
// res[3] = 234;
Print(res);
Pos_array(res);

