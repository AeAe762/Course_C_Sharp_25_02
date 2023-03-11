// Задача 1: Напишите программу, которая принимает на вход число (А) и выдаёт сумму 
// чисел от 1 до А.
// 7 -> 28 
// 4 -> 10 
// 8 -> 36

int SumNum (int num)
{
  int all_sum = 0;
  for (int i = 1; i <= num; i++)
    all_sum += i;
  
  return all_sum;
}
int result = SumNum(int.Parse(Console.ReadLine()!));
Console.WriteLine(result);