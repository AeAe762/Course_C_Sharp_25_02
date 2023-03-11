// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void Mass (int[] array)
{
  int size = array. Length;
  for (int i = 0; i < size; i++)
    Console.Write ($" {array[i]} ");
  Console.WriteLine() ;
}
int [] Mass_1 (int size, int first, int last)
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++)
    array[i] = new Random() . Next (first, last);
  return array;
}

int num = int. Parse (Console. ReadLine () !);
int first = int.Parse(Console. ReadLine()!);
int last = int. Parse (Console. ReadLine()!);
int[] mass = Mass_1 (num. firtst. last);
print(mass);