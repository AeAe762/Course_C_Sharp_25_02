// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные
// натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

// Шаг на убывание
void EvenNum (int M, int N)
{
  if (M > N) return;
  if ( N % 2 == 0)
  {
    EvenNum(M, N - 2);
    Console.Write($"{N} ");
  }
  else 
  {
    N = N - 1;
    EvenNum(M, N - 2);
    Console.Write($"{N} ");
  }
}
Console.Write("Введите число М: ");
int NumM = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int NumN = int.Parse(Console.ReadLine()!);
EvenNum(NumM, NumN);

// Шаг на возрастание
void EvenNum2 (int M, int N)
{
  if (M > N) return;
  if ( M % 2 == 0)
  {
    EvenNum2(M + 2, N);
    Console.Write($"{M} ");
  }
  else 
  {
    M = M + 1;
    EvenNum2(M + 2, N);
    Console.Write($"{M} ");
  }
}
Console.Write("Введите число М: ");
int NumM2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int NumN2 = int.Parse(Console.ReadLine()!);
EvenNum2(NumM2, NumN2);
