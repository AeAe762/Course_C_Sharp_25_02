// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный 
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void Massive (int lenght)
{
  int[] R = new int [lenght];
  for (int i = 0; i < lenght; i++)
  {
    R[i] = new Random().Next(2);
    Console.Write($"{R[i]} ");
  }
}
Massive(int.Parse(Console.ReadLine()!));