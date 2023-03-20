// Задача 1: Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1] 
// [6 7 3 6] -> [6 3 7 6]

int[] Fill_Array(int size, int from, int to)
{
  int[] array = new int[size];
  for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(from, to);
  return array;
}
void Print(int[] num_1)
{
  for (int i = 0; i < num_1.Length; i++) Console.Write($"{num_1[i]} ");
Console.WriteLine();
}

void RevMas (int [] arr) // Функция которая будет менять числа местами;
{
  int size = arr.Length;
  for (int i = 0; i < size / 2; i++)
    (arr[i], arr[size - i - 1]) = (arr[size - i - 1], arr[i]);  // Кортеж который меняет 
  // числа местами через индексы; arr[size - i - 1] - считает индексы в обратном порядке}
}

Console.Write($"Введите размер массива: ");
int size_1 = int.Parse(Console.ReadLine()!);
Console.Write($"Введите начально число массива: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write($"Введите конечное число массива: ");
int stop = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Массив:");
int[] mass = Fill_Array(size_1, start, stop);
Print(mass);
RevMas(mass);
Console.WriteLine($" Новый массив");
Print(mass);
