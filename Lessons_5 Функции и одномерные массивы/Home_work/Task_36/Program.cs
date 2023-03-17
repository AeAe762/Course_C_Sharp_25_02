// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму 
// элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
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
void Summa_Index(int[] num)
{
  int summa = 0;
  for (int i = 1; i < num.Length; i = i + 2) summa += num[i];
  Console.WriteLine();
  Console.WriteLine($"Сумма нечетных элементов = {summa}");
}
int size = int.Parse(Console.ReadLine()!);
int from = int.Parse(Console.ReadLine()!); // - 100; 
int to = int.Parse(Console.ReadLine()!); //100; 
int[] res = Fill_Array(size, from, to);
// res[0] = 3;
// res[1] = -12;
// res[2] = 23;
// res[3] = 12;
Print(res);
Summa_Index(res);