// Задача 1: Напишите программу, которая принимает на вход число и выдаёт количество 
// цифр в числе.
// 456 -> 3 
// 78 -> 2 
// 89126 -> 5

int Count_num (int num)
{
  int count = 0;
  for (int i = 0; num > 0; i++)
    {
       num = num / 10;
       count ++;
    }
  return count;   
}
int result = Count_num(int.Parse(Console.ReadLine()!));
Console.WriteLine($"Количество цифр в числе = {result}");