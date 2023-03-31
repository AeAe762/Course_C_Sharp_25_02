// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int SumElement (int M, int N)
{
  int summa = 0;
  if (M > N) return summa;
  else 
  return SumElement(M, N -1) + summa + N;
}

Console.Write("Введите число М: ");
int NumM = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int NumN = int.Parse(Console.ReadLine()!);
int result = SumElement(NumM, NumN);
Console.WriteLine(result);

