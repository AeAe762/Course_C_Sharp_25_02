// Задача 2: Напишите программу, которая принимает на вход число N и выдаёт 
// произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int Multi_Num (int num)
{
  int multi = 1;
  for (int i = 1; i <= num; i ++)
  multi *= i;
return multi;
}
int result = Multi_Num(int.Parse(Console.ReadLine()!));
Console.WriteLine($"Произведение числа num = {result}");